public static class GlobalMembers
{
	public static double VERSION = 1.43;

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define WM_MYMESSAGE (WM_USER + 1)

	public delegate uint GetTcpInfo(object NamelessParameter1, ref uint NamelessParameter2, int NamelessParameter3, uint NamelessParameter4, TCP_TABLE_CLASS NamelessParameter5, uint NamelessParameter6);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//static uint CaptureThread(object arg);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//static void Exit();

	public static System.IntPtr hInst;
	public static string szTitle = new string(new char[DefineConstants.MAX_LOADSTRING]);
	public static string szWindowClass = new string(new char[DefineConstants.MAX_LOADSTRING]);
	public static string url = new string(new char[DefineConstants.MAX_LOADSTRING]);
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: char* titleWide;
	public static char titleWide;
	public static NOTIFYICONDATA nid = new NOTIFYICONDATA();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//ushort Class(System.IntPtr hInstance);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//System.IntPtr InitInstance(System.IntPtr NamelessParameter1, int NamelessParameter2);
//C++ TO C# CONVERTER NOTE: CALLBACK is not available in C#:
//ORIGINAL LINE: int CALLBACK WndProc(System.IntPtr, uint, System.IntPtr, System.IntPtr);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//int WndProc(System.IntPtr NamelessParameter1, uint NamelessParameter2, System.IntPtr NamelessParameter3, System.IntPtr NamelessParameter4);
	public static System.IntPtr mutex;

	internal static string DEBUG_LOG_FILE_NAME = "debug.log";

	public static byte[] header = {0x52, 0x52, 0xA0, 0x41, 0xFF, 0x5D, 0x46};
	public static uint lastPacket = 0;
	public static uint status = 0;
	public static uint FFXIVLen = sizeof(FFXIV) - sizeof(byte*);
}

public class FFXIV
{
	public byte[] u1 = new byte[16];
	public ulong timestamp;
	public uint len;
	public byte[] u2 = new byte[2];
	public ushort count;
	public byte flag1;
	public byte compressed;
	public byte[] u3 = new byte[6];
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: byte* data;
	public byte data;
}

public class FFXIV_msg
{
	public uint size;
	public ulong u1;
	public ushort u2;
	public ushort type;
}



internal static partial class DefineConstants
{
	public const int MAXBUF = 0xFFFF;
	public const int MAX_LOADSTRING = 100;
	public const int CMD_OPEN_MATCH = 1001;
	public const int CMD_COPY_LINK = 1002;
	public const int CMD_EXIT = 1003;
	public const int CMD_OPEN_HOME = 1004;
}

public static class GlobalMembers
{
	public static SealRock SealRockArgs = null;
	public static uint players = 0;
}

public class SealRock
{
	public byte[][] playerData;
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: byte* matchData;
	public byte matchData;
	public uint players;
}
