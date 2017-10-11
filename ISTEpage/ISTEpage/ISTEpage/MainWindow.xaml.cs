using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ISTEpage.ViewModel;
using System.Diagnostics;

namespace ISTEpage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AboutViewModel vm;
        DegreesViewModel dvm;
        DegreeGradViewModel dgvm;
        MinorsViewModel mvm;
        EmploymentViewModel evm;

        public List<String> Concentrations0 { get; set; }
        public List<String> Concentrations1 { get; set; }
        public List<String> Concentrations2 { get; set; }
        public List<String> Concentrations10 { get; set; }
        public List<String> Concentrations11 { get; set; }
        public List<String> Concentrations12 { get; set; }
        public List<String> Courses0 { get; set; }
        public List<String> Courses1 { get; set; }
        public List<String> Courses2 { get; set; }
        public List<String> Courses7 { get; set; }
        public List<String> Courses6 { get; set; }
        public List<String> Courses5 { get; set; }
        public List<String> Courses4 { get; set; }
        public List<String> Courses3 { get; set; }
        public List<String> GradConcentrations0 { get; set; }
        public List<String> GradConcentrations1 { get; set; }
        public List<string> GradConcentrations2 { get; private set; }

        //For FOOTER
        public void applyNow_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        public void aboutThisSite_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        public void supportIst_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        public void labHours_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        public void login_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        public void rochester_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        public void address_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        public MainWindow()
        {
            //For ABOUT section
            InitializeComponent();
            //For CONTACT FORM
            contact_form.NavigationService.Navigate(new Uri("http://ist.rit.edu/assets/includes/calls/calls.php?area=aboutSite"));

            //For MAP
            map.NavigationService.Navigate(new Uri("http://ist.rit.edu/api/map/"));

            


        vm = new AboutViewModel();
            //this.DataContext = vm;
            vm.GetData();
            title.Text = vm.ItemTitle;
            description.Text = vm.ItemDescription;
            quote.Text = vm.ItemQuote;
            quoteAuthor.Text = vm.ItemQuoteAuthor;

            //For UNDERGRADUATE section
            dvm = new DegreesViewModel();
            dvm.GetData();
                      
            underHeader0.Header = dvm.Titleunder[0];
            underHeader1.Header = dvm.Titleunder[1];
            underHeader2.Header = dvm.Titleunder[2];

            
            title0.Text = dvm.AllDegrees.undergradute[0].title;
            description0.Text = dvm.AllDegrees.undergradute[0].description;
            this.Concentrations0 = dvm.AllDegrees.undergradute[0].concentrations;
            DataContext = this;

            title1.Text = dvm.AllDegrees.undergradute[1].title;
            description1.Text = dvm.AllDegrees.undergradute[1].description;
            this.Concentrations1 = dvm.AllDegrees.undergradute[1].concentrations;
            DataContext = this;

            title2.Text = dvm.AllDegrees.undergradute[2].title;
            description2.Text = dvm.AllDegrees.undergradute[2].description;
            this.Concentrations2 = dvm.AllDegrees.undergradute[2].concentrations;
            DataContext = this;

            //For GRADUATE section
            dgvm = new DegreeGradViewModel();
            dgvm.GetData();
            gradHeader0.Header = dgvm.Titlegrad[0];
            gradHeader1.Header = dgvm.Titlegrad[1];
            gradHeader2.Header = dgvm.Titlegrad[2];

            gradTitle0.Text = dgvm.AllDegreeGrad.graduate[0].title;
            gradDescription0.Text = dgvm.AllDegreeGrad.graduate[0].description;
            this.GradConcentrations0 = dgvm.AllDegreeGrad.graduate[0].concentrations;
            DataContext = this;

            gradTitle1.Text = dgvm.AllDegreeGrad.graduate[1].title;
            gradDescription1.Text = dgvm.AllDegreeGrad.graduate[1].description;
            this.GradConcentrations1 = dgvm.AllDegreeGrad.graduate[1].concentrations;
            DataContext = this;

            gradTitle2.Text = dgvm.AllDegreeGrad.graduate[2].title;
            gradDescription2.Text = dgvm.AllDegreeGrad.graduate[2].description;
            this.GradConcentrations2 = dgvm.AllDegreeGrad.graduate[2].concentrations;
            DataContext = this;

            //For Employment Section
            evm = new EmploymentViewModel();
            evm.getData();

            employTitle.Text = evm.allemployes.title;
            EmploymentDesc.Text = evm.allemployes.description0;
            CoopTitle.Text = evm.allemployes.description1;



            //For Minors section

            mvm = new MinorsViewModel();
            mvm.GetData();

            minorHeader0.Header = mvm.MinorTitle[0];
            minorHeader1.Header = mvm.MinorTitle[1];
            minorHeader2.Header = mvm.MinorTitle[2];
            minorHeader3.Header = mvm.MinorTitle[3];
            minorHeader4.Header = mvm.MinorTitle[4];
            minorHeader5.Header = mvm.MinorTitle[5];
            minorHeader6.Header = mvm.MinorTitle[6];
            minorHeader7.Header = mvm.MinorTitle[7];

            minorTitle0.Text = mvm.AllMinors.UgMinors[0].title;
            minorDescription0.Text = mvm.AllMinors.UgMinors[0].description;
            minorNote0.Text = mvm.AllMinors.UgMinors[0].note;
            this.Courses0 = mvm.AllMinors.UgMinors[0].courses;
            DataContext = this;

            minorTitle1.Text = mvm.AllMinors.UgMinors[1].title;
            minorDescription1.Text = mvm.AllMinors.UgMinors[1].description;
            minorNote1.Text = mvm.AllMinors.UgMinors[1].note;
            this.Courses1 = mvm.AllMinors.UgMinors[1].courses;
            DataContext = this;

            minorTitle2.Text = mvm.AllMinors.UgMinors[2].title;
            minorDescription2.Text = mvm.AllMinors.UgMinors[2].description;
            minorNote2.Text = mvm.AllMinors.UgMinors[2].note;
            this.Courses2 = mvm.AllMinors.UgMinors[2].courses;
            DataContext = this;

            minorTitle3.Text = mvm.AllMinors.UgMinors[3].title;
            minorDescription3.Text = mvm.AllMinors.UgMinors[3].description;
            minorNote3.Text = mvm.AllMinors.UgMinors[3].note;
            this.Courses3 = mvm.AllMinors.UgMinors[3].courses;
            DataContext = this;

            minorTitle4.Text = mvm.AllMinors.UgMinors[4].title;
            minorDescription4.Text = mvm.AllMinors.UgMinors[4].description;
            minorNote4.Text = mvm.AllMinors.UgMinors[4].note;
            this.Courses4 = mvm.AllMinors.UgMinors[4].courses;
            DataContext = this;

            minorTitle5.Text = mvm.AllMinors.UgMinors[5].title;
            minorDescription5.Text = mvm.AllMinors.UgMinors[5].description;
            minorNote5.Text = mvm.AllMinors.UgMinors[5].note;
            this.Courses5 = mvm.AllMinors.UgMinors[5].courses;
            DataContext = this;

            minorTitle6.Text = mvm.AllMinors.UgMinors[6].title;
            minorDescription6.Text = mvm.AllMinors.UgMinors[6].description;
            minorNote6.Text = mvm.AllMinors.UgMinors[6].note;
            this.Courses6 = mvm.AllMinors.UgMinors[6].courses;
            DataContext = this;

            minorTitle7.Text = mvm.AllMinors.UgMinors[7].title;
            minorDescription7.Text = mvm.AllMinors.UgMinors[7].description;
            minorNote7.Text = mvm.AllMinors.UgMinors[7].note;
            this.Courses7 = mvm.AllMinors.UgMinors[7].courses;
            DataContext = this;


        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }
    }
}
