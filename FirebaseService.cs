using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http; 
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

using FireSharp.Response;
using Newtonsoft.Json;


namespace Otomasyon_1
{
    internal class FirebaseService
    {
        
      

        public static IFirebaseClient client;

        public static void Connect()
        {
            if (client != null) return;

            try
            {

                IFirebaseConfig Config = new FirebaseConfig
            {
                AuthSecret = "nHoGy6Hclb0Zf7MwDvtn8vHC1ZTarfAO8s9CEPHJ",
                BasePath = "https://otomasyon-1-1c607-default-rtdb.firebaseio.com/"
            };

            //IFirebaseClient client;
            //client = new FirebaseClient(Config);

            client = new FireSharp.FirebaseClient(Config);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Firebase bağlantı hatası: " + ex.Message);
            }
        }

    }


    
}
