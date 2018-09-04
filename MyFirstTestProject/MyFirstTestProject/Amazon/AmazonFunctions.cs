/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/28/2018
 * Time: 4:31 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using MyFirstTestProject;
using System.Threading;

using Ranorex;

namespace MyFirstTestProject.Amazon
{
	/// <summary>
	/// Description of AmazonFunctions.
	/// </summary>
	public class AmazonFunctions : CommonFunctions
	{
		public MyFirstTestProject.Repository.Amazon_Repo amazonRepo;
				
		public AmazonFunctions()
		{
			amazonRepo = MyFirstTestProject.Repository.Amazon_Repo.Instance;
		}
		
		public void LanuchAmazon(string strBrowserLink = "www.amazon.in"){
			//closeBrowser("chrome");
			if (strBrowserLink.Equals("www.amazon.in")) {
				amazonRepo.strWebAddress = strBrowserLink;
				amazonRepo.strLoginId = "nav-link-yourAccount";
			}
			else if (strBrowserLink.Equals("www.amazon.com")) {
				amazonRepo.strWebAddress = strBrowserLink;
				amazonRepo.strLoginId = "nav-link-accountList";
			}
			else{
				Report.Failure("Test case failed because provided web address dose not match.");
			}
			
			Host.Local.OpenBrowser(strBrowserLink,"chrome","",false,true,false,false,false);
			Thread.Sleep(2000);
			SuccessWithScreenshot("Amazon website launched");
		}
		
		public void LoginAmazon(){
			if (amazonRepo.AmazonComOnlineShoppingForElectron.link_LoginInfo.Exists(5000)) {
				Click_fn(amazonRepo.AmazonComOnlineShoppingForElectron.link_Login);
				if (amazonRepo.AmazonComOnlineShoppingForElectron.txt_UserNameInfo.Exists(5000)) {
					textValue_fn(amazonRepo.AmazonComOnlineShoppingForElectron.txt_UserName,"value","8320417466");
					Click_fn(amazonRepo.AmazonComOnlineShoppingForElectron.btn_Continue);
					textValue_fn(amazonRepo.AmazonComOnlineShoppingForElectron.txt_Password,"value","Goodluck@1994");
					Click_fn(amazonRepo.AmazonComOnlineShoppingForElectron.btn_Login);
				}
			}
		}
		
		public void searchItemOnAmazon(string itemName){
			
			textValue_fn(amazonRepo.AmazonComOnlineShoppingForElectron.txt_SearchBar,"value",itemName);
			amazonRepo.AmazonComOnlineShoppingForElectron.txt_SearchBar.PressKeys("{ENTER}");

			
		}
	}
}
