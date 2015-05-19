using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;                             // application
using System.IO;                                        // path + file
using System.Runtime.Serialization.Formatters.Binary;   // formatter

namespace SafeLess
{
    [Serializable]
    public class Configuration 
    {
        public string configVersion = Settings.configVersion;

        public int formPosX = 100;          // defaults
        public int formPosY = 100;

        public string user = "User 1";
        public bool hideMaster = false;
        public bool hidePassword = false;
        public bool ctrlUP = true;
        public bool lower = true;
        public bool upper = false;
        public bool digit = false;
        public bool speci = false;
        public int length = 8;

        public string res_string1 = "";     // reserved
        public string res_string2 = "";
        public bool res_bool1 = false;
        public bool res_bool2 = false;
        public int res_int1 = 0;
        public int res_int2 = 0;

        public SortedList<string, Form1.SiteData> siteList = new SortedList<string, Form1.SiteData>();
    }

    public class Settings
    {
        public const string configVersion = "CONFIG_VERSION_1.1";

	    public Settings()
	    {
	    }

	    public static Configuration config = new Configuration();

	    private static String GetFilePath()
	    {
		    return Application.StartupPath + @"\config.dat";
	    }

	    public static void Save()
	    {
		    Stream write = null;

		    try{
			    FileInfo fi = new FileInfo(GetFilePath());
			    write = fi.OpenWrite();
			    BinaryFormatter bf = new BinaryFormatter();
			    bf.Serialize(write, config);
		    }

		    catch(Exception){
		    }

		    finally{
			    if(write != null)
				    write.Close();
		    }
	    }

	    public static Boolean Load()
	    {
		    Boolean err = false;
            Stream read = null;

		    try{
			    FileInfo fi = new FileInfo(GetFilePath());
			    read = fi.OpenRead();
			    BinaryFormatter bf = new BinaryFormatter();
			    Configuration tmp = (Configuration)bf.Deserialize(read);

                if(tmp.configVersion == configVersion)
			        config = tmp;
                else
                    err = true;
		    }

		    catch(Exception){
		        err = true;
            }

		    finally{
			    if(read != null)
				    read.Close();
            }
            
            return err;
        }
    }
}
