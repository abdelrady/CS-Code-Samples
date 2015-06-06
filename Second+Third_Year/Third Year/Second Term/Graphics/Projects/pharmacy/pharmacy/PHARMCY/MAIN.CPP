#include<iostream>
#include<conio.h>
#include"RFS.h"
#include"Med.h"
#include"Ccom.h"
using namespace std;
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
//              Functions header
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
void CleanScreen(void);
int  ShowMenu(void);
bool AddNewMedicine(RFS* CMed,RFS* Ccom);
int  AddNewCompany(RFS* Com);
bool RemoveMedicine(RFS* CMed);
bool RemoveCompany(RFS* Com,RFS* CMed);
bool ModifyMedicine(RFS* CMed);
bool ModifyCompany(RFS* Com);
bool SearchForMedicine(RFS* CMed,RFS* Com);
bool searchforcompanywithmedcine(RFS * Com,RFS* CMed);
char againYON();
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
void main (void)
{
	RFS medicine(sizeof(Med),"Medicine.db");
	RFS company(sizeof(Ccom),"Company.db");
	char again;  //a flag to indicate do selected option again
	int choice;  //user selected option
	bool exit=false;  // falg to terminate excution
	while(true) //loop forever
	{
		CleanScreen();
		choice=ShowMenu(); //show menu and get user option
		switch(choice)  //handling user input
		{
		case 1: // Adding a new Medicine to the Medicine file
			again='Y';
			while(again=='Y') //loop as user wants to continue
			{
				if(AddNewMedicine(&medicine,&company))
				{
					cout<<"\na New Medicine has been successfuly added\n";
					cout<<"Do you want to add another (y/n)?";
					again=againYON();
				}
				else //failed to add a student to library
				{
					again='N';
					cout<<"couldn't add a New Medicine\n";
					cout<<"Press any key to continue";
					_getch();
				}
			}
			break;
		case 2: // Adding a new Company to the Company file
			again='Y';
			while(again=='Y') //loop as user wants to continue
			{
				if(searchforcompanywithmedcine(&company,&medicine))
				{

					cout<<"Do you want to add another (y/n)?";
					again=againYON();
				}
				else //failed to add a Company to Company file
				{
					again='N';
					cout<<"couldn't display\n";
					cout<<"Press any key to continue";
					_getch();
				}
			}
			break;
		case 3: //remove a medicine from the Medicine file
			again='Y';
			while(again=='Y')
			{
				if(RemoveMedicine(&medicine))
				{
					cout<<"a Medicine has been successfuly removed\n";
					cout<<"Do you want to add another (y/n)?";
					again=againYON();
				}
				else // failed to remove a Medicine from Medicine file
				{
					again='N';
					cout<<"couldn't remove a Medicine\n";
					cout<<"Press any key to continue";
					_getch();
				}
			}
			break;
		case 4: //remove a Company from the Company file
			again='Y';
			while(again=='Y')
			{
				if(RemoveCompany(&company,&medicine))
				{
					cout<<"a Company has been successfuly removed\n";
					cout<<"Do you want to remove another (y/n)?";
					again=againYON();
				}
				else // failed to remove a Company from Company file
				{
					again='N';
					cout<<"couldn't remove a Company\n";
					cout<<"Press any key to continue";
					_getch();
				}
			}
			break;
		case 5:  // modify Medicine data
			again='Y';
			while(again=='Y')
			{
				if(ModifyMedicine(&medicine))
				{
					cout<<"a Medicine has been successfuly modified\n";
					cout<<"Do you want to modify another (y/n)?";
					again=againYON();
				}
				else  // failed to modify Medicine data
				{
					again='N';
					cout<<"couldn't modify a Medicine\n";
					cout<<"Press any key to continue";
					_getch();
				}
			}
			break;
		case 6:  // modify Company data
			again='Y';
			while(again=='Y')
			{
				if(ModifyCompany(&company))
				{
					cout<<"a Company has been successfuly modified\n";
					cout<<"Do you want to modify another (y/n)?";
					again=againYON();
				}
				else  // failed to modify Company data
				{
					again='N';
					cout<<"couldn't modify a Company\n";
					cout<<"Press any key to continue";
					_getch();
				}
			}
			break;
		case 7: // search for a Medicine by name(the first matched will be displayed)
			again='Y';
			while(again=='Y')
			{
				if(SearchForMedicine(&medicine,&company))
				{
					cout<<"Do you want to search for another (y/n)?";
					again=againYON();
				}
				else // failed to find a matching Medicine name
				{
					again='N';
					cout<<"couldn't find specified Medicine\n";
					cout<<"Press any key to continue[The main Menu]";
					_getch();
				}
			}
			break;
		case 8: // terminate excution
			exit=true; //set exit falg
			break;
		}
		// break infinite loop to terminate excution
		if(exit)
			break;
	}
}
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
char againYON()
{
	char again='0';
	while((again!='Y')&&(again!='N'))
	{
		cin.clear();
		cout.flush();
		again=_getch();
		again=toupper(again);
	}
	return again;
}
