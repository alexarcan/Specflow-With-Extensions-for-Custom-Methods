using LoginProject.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace LoginProject.Steps
{
    [Binding]
    public class LoginSteps : TechTalk.SpecFlow.Steps
    {
        private readonly LoginPage _loginPage = new LoginPage();
        private readonly UserFormPage _userForm = new UserFormPage();

        [Given(@"I login into the application")]
        public void GivenILoginIntoTheApplication(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _loginPage.NavigateTo("http://executeautomation.com/demosite/Login.html");
            _loginPage.Login(data.UserName, data.Password);
            _loginPage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _userForm.EnterUserDetails(data.Title, data.FirstName, data.Initial);
            _userForm.CheckTitle();
        }

        /*************************RE-USING EXISTING STEPS********************************/
        [Given(@"I login and enter user details")]
        public void GivenILoginAndEnterUserDetails()
        {
            //Create a column header
            string[] colHeader = { "UserName", "Password" };
            string[] row = { "admin", "admin" };

            var table = new Table(colHeader);
            table.AddRow(row);

            //Call another step method from the class
            Given("I login into the application", table);

            string[] colHeaderForUserForm = { "Title", "Initial", "FirstName" };
            string[] rowForUserForm = { "Mr.", "A", "Alex" };
            table = new Table(colHeaderForUserForm);
            table.AddRow(rowForUserForm);
            Given("I enter the following details", table);

        }

        [Then(@"I click save button")]
        public void ThenIClickSaveButton()
        {

        }

    }
}
