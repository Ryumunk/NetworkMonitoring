
Imports System.ComponentModel
Imports System.Text
Imports System
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.InteropServices
Module arp
    Public Class GetIpNetTable
        Private Const MAXLEN_PHYSADDR As Integer = 6

        Private Declare Function GetIpNetTable Lib "Iphlpapi" (
ByVal pIpNetTable As IntPtr,
ByRef pdwSize As Integer, ByVal bOrder As Boolean) As Integer
        Private Structure MIB_IPNETROW
            Dim dwIndex As Integer
            Dim dwPhysAddrLen As Integer
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAXLEN_PHYSADDR)> Dim dwPhysAddr As Byte()
            Dim dwAddr As Integer
            Dim dwStructure As Integer
        End Structure 'MIB_IPNETROW' 

        Private Function ConvertMacAddress(ByVal byteArray() As Byte) As String
            Dim builder As New StringBuilder
            For Each byteCurrent As Byte In byteArray
                builder.Append(byteCurrent.ToString("X").PadLeft(2, "0") & "-")
            Next byteCurrent
            Return builder.Remove(builder.Length - 1, 1).ToString
        End Function 'ConvertMacAddress' 

        Private Function IntegerToByteArray(ByVal number As Integer) As Byte()
            ' Destination byte array. 
            Dim byteArray(3) As Byte
            ' Create Gchandle instance and pin variable required, so the garbage collector won't move it. 
            Dim handle As GCHandle = GCHandle.Alloc(number, GCHandleType.Pinned)
            ' Get address of variable in pointer variable. 
            Dim address As IntPtr = handle.AddrOfPinnedObject()
            ' Use copy method to copy number to byte array. 
            Marshal.Copy(address, byteArray, 0, 4)
            Return byteArray
        End Function 'IntegerToByteArray' 

        Private Function ConvertIpAddress(ByVal byteArray() As Byte) As String
            Dim address As String = String.Empty
            For Each byteCurrent As Byte In byteArray
                address &= byteCurrent.ToString & "."
            Next byteCurrent
            Return address.Remove(address.Length - 1, 1)
        End Function 'ConvertIpAddress' 

        Public Function LoadTableEntries() As ArrayList
            Const ERROR_INSUFFICIENT_BUFFER As Integer = &H7A
            Dim listEntries As New ArrayList
            ' The number of bytes needed. 
            Dim bytesNeeded As Integer = 0
            ' The result from the API call. 
            Dim result As Integer = GetIpNetTable(IntPtr.Zero, bytesNeeded, False)
            ' Call the function, expecting an insufficient buffer. 
            If result <> ERROR_INSUFFICIENT_BUFFER Then
                Throw New Win32Exception(result)
            End If
            ' Allocate the memory, do it in a try/finally block, to ensure 
            ' that it is released. 
            Dim Buffer As IntPtr = IntPtr.Zero
            Try
                ' Allocate the memory. 
                Buffer = Marshal.AllocCoTaskMem(bytesNeeded)
                ' Make the call again. If it did not succeed, then 
                ' raise an error. 
                result = GetIpNetTable(Buffer, bytesNeeded, False)
                ' If the result is not 0 (no error), then throw an exception. 
                If (result <> 0) Then
                    ' Throw an exception. 
                    Throw New Win32Exception(result)
                Else
                    ' Now we have the buffer, we have to marshal it. We can read() 
                    ' the first 4 bytes to get the length of the buffer. 
                    Dim entries As Integer = Marshal.ReadInt32(Buffer)
                    ' Increment the memory pointer by the size of the int. 
                    Dim currentBuffer As New IntPtr(Buffer.ToInt64() + Marshal.SizeOf(GetType(Integer)))
                    ' Allocate an array of entries. 
                    Dim table(entries) As MIB_IPNETROW
                    ' Cycle through the entries. 
                    For index As Integer = 0 To entries - 1
                        table(index) = Marshal.PtrToStructure(currentBuffer, GetType(MIB_IPNETROW))
                        Dim macAddress As String = ConvertMacAddress(table(index).dwPhysAddr)
                        Dim ipAddress As String = ConvertIpAddress(IntegerToByteArray(table(index).dwAddr))
                        listEntries.Add(New DictionaryEntry(macAddress, ipAddress))
                        currentBuffer = New IntPtr(Buffer.ToInt64 + 4 + Marshal.SizeOf(GetType(MIB_IPNETROW)))
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ' Release the memory. 
                Marshal.FreeCoTaskMem(Buffer)
            End Try
            Return listEntries
        End Function 'LoadTableEntries' 

    End Class
End Module
