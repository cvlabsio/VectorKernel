﻿using System;

namespace GetProcHandleClient.Interop
{
    [Flags]
    internal enum ACCESS_MASK : uint
    {
        NO_ACCESS = 0x00000000,

        // For Files
        FILE_ANY_ACCESS = 0x00000000,
        FILE_READ_ACCESS = 0x00000001,
        FILE_WRITE_ACCESS = 0x00000002,
        FILE_READ_DATA = 0x00000001,
        FILE_LIST_DIRECTORY = 0x00000001,
        FILE_WRITE_DATA = 0x00000002,
        FILE_ADD_FILE = 0x00000002,
        FILE_APPEND_DATA = 0x00000004,
        FILE_ADD_SUBDIRECTORY = 0x00000004,
        FILE_CREATE_PIPE_INSTANCE = 0x00000004,
        FILE_READ_EA = 0x00000008,
        FILE_WRITE_EA = 0x00000010,
        FILE_EXECUTE = 0x00000020,
        FILE_TRAVERSE = 0x00000020,
        FILE_DELETE_CHILD = 0x00000040,
        FILE_READ_ATTRIBUTES = 0x00000080,
        FILE_WRITE_ATTRIBUTES = 0x00000100,
        FILE_ALL_ACCESS = 0x001F01FF,
        FILE_GENERIC_READ = 0x00100089,
        FILE_GENERIC_WRITE = 0x00100116,
        FILE_GENERIC_EXECUTE = 0x001000A0,

        // Standard and Generic Rights
        DELETE = 0x00010000,
        READ_CONTROL = 0x00020000,
        WRITE_DAC = 0x00040000,
        WRITE_OWNER = 0x00080000,
        SYNCHRONIZE = 0x00100000,
        STANDARD_RIGHTS_REQUIRED = 0x000F0000,
        STANDARD_RIGHTS_READ = 0x00020000,
        STANDARD_RIGHTS_WRITE = 0x00020000,
        STANDARD_RIGHTS_EXECUTE = 0x00020000,
        STANDARD_RIGHTS_ALL = 0x001F0000,
        ACCESS_SYSTEM_SECURITY = 0x01000000,
        MAXIMUM_ALLOWED = 0x02000000,
        GENERIC_ALL = 0x10000000,
        GENERIC_EXECUTE = 0x20000000,
        GENERIC_WRITE = 0x40000000,
        GENERIC_READ = 0x80000000,
    }

    internal enum FILE_ATTRIBUTE_FLAGS
    {
        READONLY = 0x00000001,
        HIDDEN = 0x00000002,
        SYSTEM = 0x00000004,
        DIRECTORY = 0x00000010,
        ARCHIVE = 0x00000020,
        DEVICE = 0x00000040,
        NORMAL = 0x00000080,
        TEMPORARY = 0x00000100,
        SPARSE_FILE = 0x00000200,
        REPARSE_POINT = 0x00000400,
        COMPRESSED = 0x00000800,
        OFFLINE = 0x00001000,
        NOT_CONTENT_INDEXED = 0x00002000,
        ENCRYPTED = 0x00004000,
        VIRTUAL = 0x00010000,
        VALID_FLAGS = 0x00007FB7,
        VALID_SET_FLAGS = 0x000031A7
    }

    [Flags]
    internal enum FILE_CREATE_OPTIONS : uint
    {
        NONE = 0x00000000,
        DIRECTORY_FILE = 0x00000001,
        WRITE_THROUGH = 0x00000002,
        SEQUENTIAL_ONLY = 0x00000004,
        NO_INTERMEDIATE_BUFFERING = 0x00000008,
        SYNCHRONOUS_IO_ALERT = 0x00000010,
        SYNCHRONOUS_IO_NONALERT = 0x00000020,
        NON_DIRECTORY_FILE = 0x00000040,
        CREATE_TREE_CONNECTION = 0x00000080,
        COMPLETE_IF_OPLOCKED = 0x00000100,
        NO_EA_KNOWLEDGE = 0x00000200,
        OPEN_FOR_RECOVERY = 0x00000400,
        RANDOM_ACCESS = 0x00000800,
        DELETE_ON_CLOSE = 0x00001000,
        OPEN_BY_FILE_ID = 0x00002000,
        OPEN_FOR_BACKUP_INTENT = 0x00004000,
        NO_COMPRESSION = 0x00008000,
        OPEN_REQUIRING_OPLOCK = 0x00010000,
        DISALLOW_EXCLUSIVE = 0x00020000,
        SESSION_AWARE = 0x00040000,
        RESERVE_OPFILTER = 0x00100000,
        OPEN_REPARSE_POINT = 0x00200000,
        OPEN_NO_RECALL = 0x00400000,
        OPEN_FOR_FREE_SPACE_QUERY = 0x00800000,
        COPY_STRUCTURED_STORAGE = 0x00000041,
        STRUCTURED_STORAGE = 0x00000441
    }

    internal enum FILE_CREATE_DISPOSITION : uint
    {
        SUPERSEDE = 0,
        OPEN = 1,
        CREATE = 2,
        OPEN_IF = 3,
        OVERWRITE = 4,
        OVERWRITE_IF = 5
    }

    [Flags]
    internal enum FILE_SHARE_ACCESS : uint
    {
        NONE = 0x00000000,
        READ = 0x00000001,
        WRITE = 0x00000002,
        DELETE = 0x00000004,
        VALID_FLAGS = 0x00000007
    }

    [Flags]
    internal enum OBJECT_ATTRIBUTES_FLAGS : uint
    {
        OBJ_INHERIT = 0x00000002,
        OBJ_PERMANENT = 0x00000010,
        OBJ_EXCLUSIVE = 0x00000020,
        OBJ_CASE_INSENSITIVE = 0x00000040,
        OBJ_OPENIF = 0x00000080,
        OBJ_OPENLINK = 0x00000100,
        OBJ_KERNEL_HANDLE = 0x00000200,
        OBJ_FORCE_ACCESS_CHECK = 0x00000400,
        OBJ_VALID_ATTRIBUTES = 0x000007F2
    }

    internal enum PROC_THREAD_ATTRIBUTES
    {
        GROUP_AFFINITY = 0x00030003,
        HANDLE_LIST = 0x00020002,
        IDEAL_PROCESSOR = 0x00030005,
        MITIGATION_POLICY = 0x00020007,
        PARENT_PROCESS = 0x00020000,
        PREFERRED_NODE = 0x00020004,
        UMS_THREAD = 0x00030006,
        SECURITY_CAPABILITIES = 0x00020009,
        PROTECTION_LEVEL = 0x0002000B,
        CHILD_PROCESS_POLICY = 0x0002000E,
        DESKTOP_APP_POLICY = 0x00020012,
        JOB_LIST = 0x0002000D,
        ENABLE_OPTIONAL_XSTATE_FEATURES = 0x0003001B,

        // Definitions for NtCreateThreadEx
        EXTENDED_FLAGS = 0x00060001, // ProcThreadAttributeValue(ProcThreadAttributeExtendedFlags, FALSE, TRUE, TRUE)
        PACKAGE_FULL_NAME = 0x00020008, // ProcThreadAttributeValue(ProcThreadAttributePackageFullName, FALSE, TRUE, FALSE)
        CONSOLE_REFERENCE = 0x0002000A, // ProcThreadAttributeValue(ProcThreadAttributeConsoleReference, FALSE, TRUE, FALSE)
        OSMAXVERSIONTESTED = 0x0002000C, // ProcThreadAttributeValue(ProcThreadAttributeOsMaxVersionTested, FALSE, TRUE, FALSE)
        SAFE_OPEN_PROMPT_ORIGIN_CLAIM = 0x00020011, // ProcThreadAttributeValue(ProcThreadAttributeSafeOpenPromptOriginClaim, FALSE, TRUE, FALSE)
        BNO_ISOLATION = 0x00020013, // ProcThreadAttributeValue(ProcThreadAttributeBnoIsolation, FALSE, TRUE, FALSE)
        ISOLATION_MANIFEST = 0x00020017, // ProcThreadAttributeValue(ProcThreadAttributeIsolationManifest, FALSE, TRUE, FALSE)
        CREATE_STORE = 0x0002001C, // ProcThreadAttributeValue(ProcThreadAttributeCreateStore, FALSE, TRUE, FALSE)
    }

    [Flags]
    internal enum PROCESS_CREATION_FLAGS : uint
    {
        DEBUG_PROCESS = 0x00000001,
        DEBUG_ONLY_THIS_PROCESS = 0x00000002,
        CREATE_SUSPENDED = 0x00000004,
        DETACHED_PROCESS = 0x00000008,
        CREATE_NEW_CONSOLE = 0x00000010,
        CREATE_NEW_PROCESS_GROUP = 0x00000200,
        CREATE_UNICODE_ENVIRONMENT = 0x00000400,
        CREATE_SEPARATE_WOW_VDM = 0x00000800,
        CREATE_SHARED_WOW_VDM = 0x00001000,
        INHERIT_PARENT_AFFINITY = 0x00010000,
        CREATE_PROTECTED_PROCESS = 0x00040000,
        EXTENDED_STARTUPINFO_PRESENT = 0x00080000,
        CREATE_BREAKAWAY_FROM_JOB = 0x01000000,
        CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x02000000,
        CREATE_DEFAULT_ERROR_MODE = 0x04000000,
        CREATE_NO_WINDOW = 0x08000000,
    }
}
