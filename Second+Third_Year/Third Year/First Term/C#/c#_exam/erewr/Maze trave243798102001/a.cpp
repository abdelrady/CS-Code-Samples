int maze(char *mazeone[12][12])
		{
index=0;
horiz=0;

			start:if (horiz==0){
			cout << TAB << TAB;
			 }

do
	{	
		cout << *mazeone[index][horiz];
		horiz++;
	}while (horiz !=12);
			
			horiz=0; // reinitialize horiz to 0

					if (index==11){
				goto finish;
				}
					else{
		cout << "\n"; index++; goto start;
					}
finish:cout << "\n\n\n\n";

return 0;

}