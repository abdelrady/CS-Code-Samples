% After facerecognition, this code captures the ID number of a person.
%Then reads the information stored in IDnumber.DAT

clc

jk=num2str(pminf);

if(exist([jk '.dat']))
    load ([jk '.dat'],'-mat');
switch (h)
    case 'y'
        
prl
    case 'Y'
        prl
        
    case 'n'
        prl2
    case 'N'
        prl2
    otherwise
        prl2
    end


  if exist('kl')
try
imshow(kl)

disp (strcat('NAME.............',num2str(a)))
disp (strcat('SURNAME..........',num2str(b)))
disp (strcat('PHONE NUMBER.....',num2str(c)))

pause
clear all
bdrfacerec
catch
clc
    disp('')
    disp('An error occured while reading the database')
    disp('Please check your variables and try again')
    pause
    clear all
    bdrfacerec
return
end
  
  else

try
clc
disp (strcat('NAME.............',num2str(a)))
disp (strcat('SURNAME..........',num2str(b)))
disp (strcat('PHONE NUMBER.....',num2str(c)))

disp('Refference Image NOT FOUND!!')
pause
clear all
bdrfacerec

catch
   clc
    disp('')
    disp('An error occured while reading the database')
    disp('Please check your variables and try again')
    pause
    clear all
    bdrfacerec
    return
end
  end
else
    disp('THERE IS NO RECORD ABOUT THE GROUP')
    pause
    clear all
    bdrfacerec
return
  end


