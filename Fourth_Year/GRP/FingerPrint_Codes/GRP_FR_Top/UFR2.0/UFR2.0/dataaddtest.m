%Stores the selected image to the database
%Stores the information about the face

clc
if exist('img')
   
    if(exist('fdata.dat')==2)
        load('fdata.dat','-mat');
         fnumber=fnumber+1;
         max_class=max_class+1;
         class_number=max_class;
         data{fnumber,1}=img(:);
         
         
                 data{fnumber,2}=class_number;
                 save('fdata.dat','data','fnumber','max_class','-append');
                    
                clc
                 disp(strcat('Face succesfully added to database with ID number --> ',num2str(class_number)));
              
                disp(' ')
                disp(' ')
   
                                 
                disp('        INFORMATION RECORD')
                disp('***********************************')
                 a=input('Name               ','s');
                 b=input('Surname            ','s');
                 c=input('Phone Number       ','s');
                 op=(strcat(num2str(class_number)));
                 disp('**************************');           
                 h=input('ALLOW ACCESS--[Y/N]','s');
                 switch(h)
                 case 'y'
                 case 'Y'
                 case 'N'
                 case 'n'
                 otherwise
                  disp('WRONG KEY!! NO ACCESS')
                 end
                 disp(' ');
 disp('Please add a refference image ')
 disp('Press any key to select your image')
 pause
 
      [ans,pathname]=uigetfile( ...
 {'*.jpg';'*.jpeg'...
 
    }, ...
    'Select an IMAGE');
 
         
 if isequal(ans,0)
 disp('ACTION CANCELLED');
 y=num2str(class_number);
 
 save([y '.dat'],'a','b','c','h','op')
 save([a '.dat'],'a','b','c','h','op')
 clc
 disp('INFORMATION IS SAVED!!!')
 disp('Press any key to continue')
 pause
 bdrfacerec
 return
 end 
    try
 
 kl=imread([pathname ans]);
 
 imshow(kl)
 save([y '.dat'],'a','b','c','h','kl','op')
 save([a '.dat'],'a','b','c','h','kl','op')
 close all
 clc
 disp('INFORMATION IS SAVED!!!')
 disp('Press any key to continue')
 pause
 bdrfacerec
 
 
    catch
        
 clc
 y=num2str(class_number);
 save([y '.dat'],'a','b','c','h')
 save([a '.dat'],'a','b','c','h')
 disp('UNKNOWN FORMAT!! The image cannot be loaded')
 disp('Other variables are saved  ')
 disp('Press any key to continue...')
 pause
 clear all
 bdrfacerec
 return
    end
        




                
     else
       clc
        fnumber=1;
        class_number=1;
        data{fnumber,1}=img(:);
        
                max_class=1;
                data{fnumber,2}=class_number;
                save('fdata.dat','data','fnumber','max_class');
                
                clc
                disp('Database was empty and has just been created.')
                disp(strcat('Face succesfully added to database with ID number-->',num2str(class_number)));
               disp(' ')
               disp(' ')
               disp('        INFORMATION RECORD')
               disp('***********************************')
                a=input('Name               ','s');
                b=input('Surname            ','s');
                c=input('Phone Number       ','s');
                op=(strcat(num2str(class_number)));
                disp('**************************');           
                h=input('ALLOW ACCESS--[Y/N]','s');
               switch(h)
                 case 'y'
                 case 'Y'
                 case 'N'
                 case 'n'
                 otherwise
                  disp('WRONG KEY!! NO ACCESS')
                  end
                 disp(' ');
 disp('Please add a refference image ')
 disp('Press any key to select your image')
 pause
 
      [ans,pathname]=uigetfile( ...
 {'*.jpg';'*.jpeg'...
 
    }, ...
    'Select an IMAGE');
 
         
  if isequal(ans,0)
 disp('ACTION CANCELLED');
 y=num2str(class_number);
 
 save([y '.dat'],'a','b','c','h','op')
 save([a '.dat'],'a','b','c','h','op')
 clc
 disp('INFORMATION IS SAVED!!!')
 disp('Press any key to continue')
 pause
 bdrfacerec
  return
  end
  
     try
 
 kl=imread([pathname ans]);
 
 imshow(kl)
 y=num2str(class_number);
 save([y '.dat'],'a','b','c','h','kl','op')
 save([a '.dat'],'a','b','c','h','kl','op')
 close all
 clc
 disp('INFORMATION SAVED!!!')
 disp('Press any key to continue')
 pause
 bdrfacerec


    catch
        
 clc
 y=num2str(class_number);
 
 save([y '.dat'],'a','b','c','h','op')
 save([a '.dat'],'a','b','c','h','op')
 
 disp('UNKNOWN IMAGE FORMAT!! The face cannot be loaded')
 disp('Other variables are saved  ')
 disp('Press any key to continue...')
 pause
 clear all
 bdrfacerec
return
    end
    end
                
   
end

                
           

