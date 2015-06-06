#include"RFS.h"
#include"Med.h"
#include"Ccom.h"
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
//              Clean Screen Function
// print an empty 25 lines
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
void CleanScreen(void)
{
	cin.ignore();
	cout.flush();
	for(int i=0;i<25;i++)
		cout<<endl;
}
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
//              Show Menu Function
// print the menu options and get user input
// return user input to calling function for processing
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
bool compareint(char ch)/////compare integer
{
	if(ch>=48&&ch<=57)
		return true;
	else
		return false;
}
//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/
bool compare(char ch)
{
	if(ch==' '||(ch>=65&&ch<=90)||(ch>=97&&ch<=122))
		return true;
	else 
		return false;
}

////////////////////////////////////////////////////////////////
int ShowMenu(void)
{
	bool ll=true;
	int choice;
		while(ll)
	{
    cout<<"\t\t\t\t MainMenu\n\n";
	cout<<"\t\t\t   (1) Add New Medicine.\n";
	cout<<"\t\t\t   (2) Search for medicine With Company\n";
	cout<<"\t\t\t   (3) Remove Medicine.\n";
	cout<<"\t\t\t   (4) Remove Company .\n";
	cout<<"\t\t\t   (5) Modify Medicine Data.\n";
	cout<<"\t\t\t   (6) Modify Company Data.\n";
	cout<<"\t\t\t   (7) Search for a Medicine.\n";
	cout<<"\t\t\t   (8) Exit.\n\n";
	cout<<"\t\t   Enter your choice (1...8) : ";
	cin>>choice;
	cin.clear();
		if(cin.good()&&(choice>=1&&choice<=9))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Enter correct number"<<endl;
			ll=true;
			
		}
	cin.ignore(5,'\n');	
	}
	
	return choice;
}
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/*/
//              Add New Company Function
// getting new Company data and add the new Company to Companies list
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/*/
int AddNewCompany(RFS * Com,char name[30])
{
	Ccom NewCompany;
	CleanScreen();
	cout<<"\t\t\tAdding New Company....\n\n\n";
	strcpy(NewCompany.m_comname,name);
   bool ll=true;
	 while(true)
	{
		cout<<"Company head name : ";
		cin.getline(NewCompany.m_headname,50);
		for(int i=0;i<strlen(NewCompany.m_headname);i++)
		{
			if(compare(NewCompany.m_headname[i]))
				ll=true;
			else
			{
				cout<<"Please try again by Entering correct chs! "<<endl;
				ll=false;
				break;
			}
			
		}
		if(ll==true)
			break;
	}
	ll=true;
	while(true)
	{
		cout<<"Enter the address :";
		cin.getline(NewCompany.m_address,100);
		for(int h=0;h<strlen(NewCompany.m_address);h++)
			if(compare(NewCompany.m_address[h])||compareint(NewCompany.m_address[h])||
				NewCompany.m_address[h]==45||NewCompany.m_address[h]==95)
				ll=true;
			else{
				cout<<"Wrong character :"<<endl;
				ll=false;
				break;
			}
		if(ll==true)
			break;
	}
	while(ll)
	{
	cout<<"\n Enter the phone number of the Company:";
	cin>>NewCompany.m_phonenum;
	cin.clear();
		if(cin.good()&&(NewCompany.m_phonenum>=100000&&NewCompany.m_phonenum<=999999))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Please Enter correct number not less or more than 6 digits!"<<endl;
			ll=true;
			cin.ignore(5,'\n');
		}
		
	}
	ll=true;
		while(ll)
	{
	cout<<"Enter the mobile number:";
	cin>>NewCompany.m_mobilenum;
	cin.clear();
		if(cin.good()&&(NewCompany.m_mobilenum>=1000000000&&NewCompany.m_mobilenum<=9999999999))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Please Enter correct number not less or more than 10 digits!"<<endl;
			ll=true;
			cin.ignore(5,'\n');
		}
		
	}
	ll=true;
	
	if(!Com->put(&NewCompany))
		return -1;
	return NewCompany.RecordNumber; 
}
//===================================================================
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/*/
//              Add New Medicine Function
// getting new Medcine data and add the new Medcine to pharmacy
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/*/
bool AddNewMedicine(RFS* CMed,RFS* Comp)
{

	
	bool ll=true;
	char arr[4][12]={"bills","drink","injection","libos"};
	Med NewMed;
	Ccom newcom;
	int num=0;
	CleanScreen();
	cout<<"\t\t\tAdding New Medecine....\n\n\n";
    while(true)
	{
		cout<<" Enter Medicine Name : ";
		cin.getline(NewMed.m_Name,50);
		cin.ignore(5,'\n');
		for(int i=0;i<strlen(NewMed.m_Name);i++)
		{
			if(compare(NewMed.m_Name[i]))
				ll=true;
			else
			{
				cout<<"Please Enter correct name!"<<endl;
				ll=false;
				break;
			}
			
		}
		if(ll==true)
			break;
	}
	ll=true;
	while(true)
	{
		cout<<" Enter Company Name : ";
		cin.getline(NewMed.m_Company_name,30);
		for(int i=0;i<strlen(NewMed.m_Company_name);i++)
		{
			if(compare(NewMed.m_Company_name[i]))
				ll=true;
			else
			{
				cout<<"Please Enter correct name!"<<endl;
				ll=false;
				break;
			}
			
		}
		if(ll==true)
			break;
	}
	ll=true;
    if(!Comp->get(&newcom,0)){
	num= AddNewCompany(Comp,NewMed.m_Company_name);
	}
	int i=0;
	while(strcmp(NewMed.m_Company_name,newcom.m_comname))
	{    
		if(!Comp->get(&newcom,i++)){
				ll=false;
		num= AddNewCompany(Comp,NewMed.m_Company_name);
		break;
		}
	}

	if(newcom.isActive()&&ll){
		newcom.active=true;
		Comp->update(&newcom);
	    NewMed.m_CompanyNum=newcom.RecordNumber;
	}
		
	else{
		num=AddNewCompany(Comp,NewMed.m_Company_name);
	}
	
	ll=true;
	while(ll)
	{
	cout<<"\n Enter the serial number of the medicine:";
	cin>>NewMed.m_SNumber;
	cin.clear();
		if(cin.good()&&(NewMed.m_SNumber>=10000000&&NewMed.m_SNumber<=99999999))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Please Enter correct number '8' digits!"<<endl;
			ll=true;
			cin.ignore(5,'\n');
		}
		
	}
	ll=true;
	
	
		while(ll)
	{
	cout<<" Medicine Price: ";
	cin>>NewMed.m_Price;
	cin.clear();
		if(cin.good()&&(NewMed.m_Price>0&&NewMed.m_Price<=9999))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Please Enter correct price not negative or more than 9999!"<<endl;
			ll=true;
			cin.ignore(5,'\n');
		}
		
	}
    ll=true;
	while(ll)
	{
	cout<<"Enter the type of the medicine 'bills','drink','libos','injections':";
	cin.getline(NewMed.type,12);
	for(int y=0;y<4;y++)
	{
		if(!strcmp(NewMed.type,arr[y]))
		{
			
			ll=false;
			break;
		}
		else ll=true;
		}
	}

	return(CMed->put(&NewMed)); //append new Medicine to pharmacy
}
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/*/
//              Remove Student Function
// remove student from school.
// this function removes the first occurence of the student number
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/*/
bool RemoveMedicine(RFS * CMed)
{
	if(CMed->GetNumberOfRecords()==0)
	{
		cout<<"There is no Medicine in the pharmacy file"<<endl;
		cout<<"Please Enter Medicines Before..."<<endl;
		return false;
	}
	Med NewMed;
	unsigned int i;
	char name[50];
	CleanScreen();
	cout<<"\t\t\tRemoving  Medecine....\n\n\n";

	bool ll=true;
	 while(true)
	{
		cout<<" Enter Medicine Name : ";///addname
		cin.getline(name,50);
		for(int i=0;i<strlen(name);i++)
		{
			if(compare(name[i]))
				ll=true;
			else
			{
				cout<<"Wrong name "<<endl;
				ll=false;
				break;
			}
			
		}//end of name for
		if(ll==true)
			break;
	}
	i=0;
	if(!CMed->get(&NewMed,i))
		return false;
	//loop if not inteded Medicine or Medicine is deleted
 	while(!(strcmp(name,NewMed.m_Name))||!NewMed.isActive())
	{
		if(!CMed->get(&NewMed,i++))
			return false;
	}
	// at this point the Med object holds the inteded Medicine
	// otherwise if the Medicine isn't exist the function fails
	return(CMed->del(&NewMed)); //now remove the Medicine from phramacy
}
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/*/
//              Remove Company Function
// remove Company from Companies list.
/*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/*/
bool RemoveCompany(RFS * Com,RFS* CMed)
{
	bool ll=true;
	int num;
	if(Com->GetNumberOfRecords()==0)
	{
		cout<<"There is no Companies in Companies file"<<endl;
		cout<<"Please Enter Companies Before..."<<endl;
		return false;
	}
	Ccom NewCom;
	Med NewMed;
	unsigned int i;
	char name[50];
	CleanScreen();
	cout<<"\t\t\tARemoving Company....\n\n\n";
	cout<<"\t\t\tRemove Company\n\n";
	
	while(true)
	{
		cout<<"Enter The Company's Name to remove it : ";
			cin.getline(name,50);
		for(int i=0;i<strlen(name);i++)
		{
			if(compare(name[i]))
				ll=true;
			else
			{
				cout<<"Wrong name "<<endl;
				ll=false;
				break;
			}
			
		}
		if(ll==true)
			break;
	}
	 i=0;
	if(!Com->get(&NewCom,i))
		return false;
	while(strcmp(NewCom.m_comname,name))
	{
		if(!Com->get(&NewCom,i++))
		return false;
	}
	if(!strcmp(NewMed.m_Company_name,NewCom.m_comname))
	num=NewCom.RecordNumber;
    i=0;
	if(!CMed->get(&NewMed,i))
		return false;
	ll=false;
	
	while(!CMed->get(&NewMed,i++))
	{
		if(num==NewMed.m_CompanyNum){
			ll=true;
            CMed->del(&NewMed);
		}
	}
	return(Com->del(&NewCom));
}
//======================================================================
       //Search For Medicicne Function
// search for the first matched Medicine name and displays its data
/*\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
bool searchforcompanywithmedcine(RFS * Com,RFS* CMed)
{
		Ccom NewCompany;
	CleanScreen();
	cout<<"\t\t\tSearching....\n\n\n";
	char name[30];
   bool ll=true;
	 while(true)
	{
			cout<<"Company  name : ";///addname
		cin.getline(name,50);
		for(int i=0;i<strlen(NewCompany.m_headname);i++)
		{
			if(compare(name[i]))
				ll=true;
			else
			{
				cout<<"Wrong name "<<endl;
				ll=false;
				break;
			}
			
		}
		if(ll==true)
			break;
	}
	 	ll=true;
    if(!Com->get(&NewCompany,0))
	return false;
	int i=0;
	while(strcmp(name,NewCompany.m_comname))
	{    
		if(!Com->get(&NewCompany,i++))
				return false;
	}


	cout<<"The data              :"<<endl;
	cout<<"Company Name :"<<NewCompany.m_comname<<endl;
	cout<<"Company_address :"<<NewCompany.m_address<<endl;
	cout<<"Company_headname :"<<NewCompany.m_headname<<endl;
	cout<<"Company_mobilenum :"<<NewCompany.m_mobilenum<<endl;
    cout<<"Company__phonenum :"<<NewCompany.m_phonenum<<endl;
	ll=true;
	return(ll);
}
//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/
bool SearchForMedicine(RFS * CMed,RFS* Com)
{
	
	bool ll=true;
	char arr[4][12]={"bills","drink","injection","libos"};
	Med NewMed;
	Ccom newcom;
	int i=0;
	char name1[30];
	 ll=true;
	CleanScreen();
	cout<<"\t\t\tSearching....\n\n\n";
	if(!CMed->get(&NewMed,i))
		return false;
    while(true)
	{
		cout<<" Enter Medicine Name : ";
		cin.getline(name1,30);
		for(int i=0;i<strlen(name1);i++)
		{
			if(compare(name1[i]))
				ll=true;
			else
			{
				cout<<"Please be sure of ur Entering try again!"<<endl;
				ll=false;
				break;
			}
			
		}
		if(ll==true)
			break;
	}
	ll=true;
	 
	while(strcmp(name1,NewMed.m_Name))
	{
		if(!CMed->get(&NewMed,i++))
			return false;
	}
	cout<<"The data              :"<<endl;
	cout<<"Medicine Name :"<<NewMed.m_Name<<endl;
	cout<<"Medicine_name :"<<NewMed.m_Company_name<<endl;
	cout<<"Medicine_Price :"<<NewMed.m_Price<<endl;
	cout<<"Medicine_Price :"<<NewMed.m_Price<<endl;
    cout<<"Medicine__SNumber :"<<NewMed.m_SNumber<<endl;
	cout<<"Medicine__type :"<<NewMed.type<<endl;

	ll=true;
	return true;
}
//=======================================================================
           //Modify For Medicicne Function
// search for the  matched Medicine name and displays its data
//Then it take the new data thet will replace the old one
/*\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\*/
bool ModifyMedicine(RFS * CMed)
{
		bool ll=true;
	char arr[4][12]={"bills","drink","injection","libos"};
	Med NewMed;
	Ccom newcom;
	int i=0;
	char name1[30];
	 ll=true;
	CleanScreen();
	cout<<"\t\t\tModifing Medecine....\n\n\n";
	if(!CMed->get(&NewMed,i))
		return false;
    while(true)
	{
		cout<<" Enter Medicine Name : ";///addname
		cin.getline(name1,30);
		for(int i=0;i<strlen(name1);i++)
		{
			if(compare(name1[i]))
				ll=true;
			else
			{
				cout<<"Please be sure of ur Entering data try again!"<<endl;
				ll=false;
				break;
			}
			
		}
		if(ll==true)
			break;
	}
	ll=true;
	 
	while(strcmp(name1,NewMed.m_Name))
	{
		if(!CMed->get(&NewMed,i++))
			return false;
	}
	cout<<"The data              :"<<endl;
	cout<<"Medicine Name :"<<NewMed.m_Name<<endl;
	cout<<"Medicine_name :"<<NewMed.m_Company_name<<endl;
	cout<<"Medicine_Price :"<<NewMed.m_Price<<endl;
	cout<<"Medicine_Price :"<<NewMed.m_Price<<endl;
    cout<<"Medicine__SNumber :"<<NewMed.m_SNumber<<endl;
	cout<<"Medicine__type :"<<NewMed.type<<endl;

	ll=true;
	while(ll)
	{
	cout<<"\n Enter the serial number of the medicine:";
	cin>>NewMed.m_SNumber;
	cin.clear();
		if(cin.good()&&(NewMed.m_SNumber>=10000000&&NewMed.m_SNumber<=99999999))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Please Enter correct number"<<endl;
			ll=true;
			cin.ignore(5,'\n');
		}
		
	}
	ll=true;
	
	
		while(ll)
	{
	cout<<" Medicine Price: ";
	cin>>NewMed.m_Price;
	cin.clear();
		if(cin.good()&&(NewMed.m_Price>0&&NewMed.m_Price<=9999))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Enter acorrect number"<<endl;
			ll=true;
			cin.ignore(5,'\n');
		}
		
	}
    ll=true;
	while(ll)
	{
	cout<<"Enter the type of the medicine 'bills','drink','libos','injections':";
	cin.getline(NewMed.type,12);
	for(int y=0;y<4;y++)
	{
		if(!strcmp(NewMed.type,arr[y]))
		{
			
			ll=false;
			break;
		}
		else ll=true;
		}
	}

	return(CMed->update(&NewMed)); //append new Medi
	}
	///////////////////////////////////////////////
bool ModifyCompany(RFS* Com)
{	
	
	Ccom NewCompany;
	CleanScreen();
	cout<<"\t\t\tModifing Company....\n\n\n";
	char name[30];
   bool ll=true;
	 while(true)
	{
			cout<<"Company  name : ";
		cin.getline(name,50);
		for(int i=0;i<strlen(NewCompany.m_headname);i++)
		{
			if(compare(name[i]))
				ll=true;
			else
			{
				cout<<"Wrong name "<<endl;
				ll=false;
				break;
			}
			
		}
		if(ll==true)
			break;
	}
	 	ll=true;
    if(!Com->get(&NewCompany,0))
	return false;
	int i=0;
	while(strcmp(name,NewCompany.m_comname))
	{    
		if(!Com->get(&NewCompany,i++))
				return false;
	}


	cout<<"The data              :"<<endl;
	cout<<"Company Name :"<<NewCompany.m_comname<<endl;
	cout<<"Company_address :"<<NewCompany.m_address<<endl;
	cout<<"Company_headname :"<<NewCompany.m_headname<<endl;
	cout<<"Company_mobilenum :"<<NewCompany.m_mobilenum<<endl;
    cout<<"Company__phonenum :"<<NewCompany.m_phonenum<<endl;
	ll=true;
	while(true)
	{
		cout<<"Enter the address :";
		cin.getline(NewCompany.m_address,100);
		for(int h=0;h<strlen(NewCompany.m_address);h++)
			if(compare(NewCompany.m_address[h])||compareint(NewCompany.m_address[h])||
				NewCompany.m_address[h]==45||NewCompany.m_address[h]==95)
				ll=true;
			else{
				cout<<"Wrong character :"<<endl;
				ll=false;
				break;
			}
		if(ll==true)
			break;
	}
	while(ll)
	{
	cout<<"\n Enter the phone number of the medicine:";
	cin>>NewCompany.m_phonenum;
	cin.clear();
		if(cin.good()&&(NewCompany.m_phonenum>=100000&&NewCompany.m_phonenum<=999999))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Enter acorrect number"<<endl;
			ll=true;
			cin.ignore(5,'\n');
		}
		
	}
	ll=true;
		while(ll)
	{
	cout<<"Enter the mobile number:";
	cin>>NewCompany.m_mobilenum;
	cin.clear();
		if(cin.good()&&(NewCompany.m_mobilenum>=1000000000&&NewCompany.m_mobilenum<=9999999999))
		{
			cin.ignore(5,'\n');
			ll=false;
			break;
		}
		else{
			cout<<"Enter acorrect number"<<endl;
			ll=true;
			cin.ignore(5,'\n');
		}
		
	}
	ll=true;
	
	return(Com->update(&NewCompany));
}

//==============================================================================
