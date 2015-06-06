%Deletes all of the databases recorded.
clc
close all


if(exist('fdata.dat')==2)
    a=input('Delete all information---->[Y/N]','s');
    switch (a)
        case 'y'
            
          delete('*.dat');
        disp('Database REMOVED')
        disp('Press any key to continue')
        pause
        bdrfacerec
        
        return
          case 'Y'
            
          delete('*.dat');
        disp('Database REMOVED')
        disp('Press any key to continue')
        pause
        bdrfacerec
        
        case 'N'
            bdrfacerec
            
        case 'n' 
            bdrfacerec
        otherwise  
            clc
        disp('Wrong SELECTION!!')
        disp(' ')
        disp('Press any key to continue...')
   pause     
deldata
        
    end

else
         clc
        disp('Database is already empty')
        disp(' ')
        disp('Press any key to continue...')
   pause 
bdrfacerec
end

