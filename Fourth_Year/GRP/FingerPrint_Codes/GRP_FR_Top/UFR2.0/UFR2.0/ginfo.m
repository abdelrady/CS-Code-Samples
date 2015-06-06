%Display information menu
%Shows the database files 
%Jumps to "dinfo.m" for displayin information

clc
clear all
disp('*****************************')
disp('Display information       [1]')
disp('Show database files       [2]') 
disp('*****************************')
disp('Back                      [B]')
disp(' ')
k=input('Your Choice-->','s');

switch(k)
    case '1'
        dinfo
        
    case '2'
            clc
        disp(' ')
        disp(' ')
        disp(' Files on the selected directory are , ')
              dir *.dat
        pause
ginfo         
    case 'b'
        bdrfacerec
    case 'B'
        bdrfacerec
    
   
        
   

    otherwise
        clc
        disp('Wrong SELECTION!!')
        disp(' ')
        disp('Press any key to continue...')
   pause     
   ginfo
end
