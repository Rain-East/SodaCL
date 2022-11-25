using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaCL.Main.Minecraft
{
    class MCMod
    {
        string version;
        string id, name;
        List<string> author;
        List<string> depend;
        string platf;// forge/fabric/...
    }
    class MCClient
    {
        public string version;
        public int addition;// forge, fabric, opti, ...
        public bool apart;

        public List<MCMod> modList;
        public DateTime createTime, lstChangeTime;
        public string path;
        public string versionJson, clientJar;

        MCClient(string version)
        {
            this.version = version;
            this.createTime = DateTime.Now;
            this.lstChangeTime = DateTime.Now;
        }
    }
}
