using System.Reflection;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System;
namespace Anomolacaris {
    public class IniFile {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);
        public IniFile(string IniPath = null) {
            try {
                Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
            } catch (Exception ex) {
                throw ex;
            }
        }
        public string Read(string Section, string Key, string Default = "") {
            try {
                var RetVal = new StringBuilder(255);
                GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
                if (string.IsNullOrEmpty(RetVal.ToString())) {
                    return Default;
                } else {
                    return RetVal.ToString();
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        public int ReadInt(string Section, string Key, int Default = 0) {
            try {
                var RetVal = new StringBuilder(255);
                GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
                if (string.IsNullOrEmpty(RetVal.ToString())) {
                    return Default;
                } else {
                    var n = 0;
                    if (int.TryParse(RetVal.ToString(), out n)) {
                        return n;
                    } else {
                        return 0;
                    }
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        public void Write(string Section, string Key, string Value) {
            try {
                WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
            } catch (Exception ex) {
                throw ex;
            }
        }
        public void DeleteKey(string Key, string Section = null) {
            try {
                Write(Key, null, Section ?? EXE);
            } catch (Exception ex) {
                throw ex;
            }
        }
        public void DeleteSection(string Section = null) {
            try {
                Write(null, null, Section ?? EXE);
            } catch (Exception ex) {
                throw ex;
            }
        }
        public bool KeyExists(string Section, string Key) {
            try {
                return Read(Section, Key).Length > 0;
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}