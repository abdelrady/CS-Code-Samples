%displays the information about people MANUALLY
%ldinfo.m displays the same information after the recognitiopn automaticly
clc

clear all
jk=input('Please Type the ID Number or Name of the person-->','s');

if(exist([jk '.dat']))
    load ([jk '.dat'],'-mat');

  if exist('kl')
try
imshow(kl)
disp (strcat('ID NUMBER........-->',num2str(op)))
disp (strcat('NAME.............',num2str(a)))
disp (strcat('SURNAME..........',num2str(b)))
disp (strcat('PHONE NUMBER.....',num2str(c)))
disp (strcat('ACCESS PERMISION.-->',num2str(h)))
pause
ginfo
catch
clc
    disp('')
    disp('An error occured while reading the database')
    disp('Please check your variables and try again')
    pause
    ginfo
return
end
  
  else

try
clc
disp (strcat('ID NUMBER........-->',num2str(op)))
disp (strcat('NAME.............',num2str(a)))
disp (strcat('SURNAME..........',num2str(b)))
disp (strcat('PHONE NUMBER.....',num2str(c)))
disp (strcat('ACCESS PERMISION.-->',num2str(h)))
disp('Refference Image NOT FOUND!!')
pause
ginfo

catch
   clc
    disp('')
    disp('An error occured while reading the database')
    disp('Please check your variables and try again')
    pause
    ginfo
    return
end
  end
else
    disp('THERE IS NO RECORD ABOUT THE PERSON')
    pause
   ginfo
return
  end


