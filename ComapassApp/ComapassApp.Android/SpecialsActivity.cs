
using Android.App;
using Android.OS;
using System.ServiceModel;

using System;
using Android.Widget;
using System.Threading;

using Android.Content;
using WcfServiceCompassLibrary;

//using E_CompassApp.localhost;
//using PnpProducts = E_CompassApp.localhost.PnpProducts;

namespace ComapassApp.Droid
{
    [Activity(Label = "SpecialsActivity")]
    public class SpecialsActivity : Activity// Activity Android.Support.V7.App.AppCompatActivity
    {
        //WcfEcompassService ecompassService;
        //private static readonly EndpointAddress Endpoint = new EndpointAddress("http://localhost:50874/EcompassService.svc");
        //public EcompassServiceClient _client { get; set; }
        //private localhost.EcompassService _client;
        //public EcompassContext _client { get; set; }

        private TextView txtSpecials;

        public string Str { get; set; } = null;
        public Button BtnLoad { get; set; } = null;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            try
            {
                SetContentView(Resource.Layout.TheSpecials);

                txtSpecials = FindViewById<TextView>(Resource.Id.txtSpecials);
                //listSpecials = FindViewById<ListView>(Resource.Id.listSpecials);

                //InitializeEcompassServiceClient();
                //ListSpecials();
                //ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, Products.Length);


                BtnLoad = FindViewById<Button>(Resource.Id.btnLoadDB);
                BtnLoad.Click += BtnLoad_Click;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
         
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            BuildStr();

            //try
            //{
            //    var geoUri = Android.Net.Uri.Parse("geo:-33.986843,25.6660153");
            //    var mapIntent = new Intent(Intent.ActionView, geoUri);
            //    StartActivity(mapIntent);
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //ListSpecials();
            //BuildStr();
        }

        private void BtnSpecials_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(SpecialsActivity));

        }

        private void ListSpecials()
        {
            txtSpecials.Text = "Waiting for WCF...";
            try
            {
                new Thread(() =>
                {
                    BuildStr();
                }).Start();

                //txtSpecials.Text = "SPECIALS";
                    
                txtSpecials.Text = Str;
                
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                txtSpecials.Text = ex.Message;
            }
        }

        private void BuildStr()
        {
            //Client = new localhost.EcompassService();
            //str = ecompassService.SayHelloTo();

            //InitializeEcompassServiceClient();
            try
            {
                //txtSpecials.Text = Client.SayHelloTo();
                //str = await _client.SayHelloToAsync(); /// after this step it jumps out of method
                //Products = await _client.Products.;
            }
            catch (Exception ex)
            {
                txtSpecials.Text = ex.Message;
                //Console.WriteLine(ex.Message);
            }

        }

        //void InitializeEcompassServiceClient()
        //{
        //    BasicHttpBinding binding = CreateBasicHttpBinding();
        //    _client = new EcompassServiceClient(binding, Endpoint);
        //}


        static BasicHttpBinding CreateBasicHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                Name = "basicHttpBinding",
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647
            };

            TimeSpan timeout = new TimeSpan(0, 0, 30);
            binding.SendTimeout = timeout;
            binding.OpenTimeout = timeout;
            binding.ReceiveTimeout = timeout;
            return binding;
        }

    }


}