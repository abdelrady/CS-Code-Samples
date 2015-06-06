%MAIN MENU OF THE SOFTWARE
%According to the users request calls corresponding script(s)
clc
disp('                    <<MAIN MENU>>       ')
disp(' ')

disp('.........Select Image....................[1]')
disp('.........New Record......................[2]')
disp('.........Number of ID(s).................[3]')
disp('.........Face Recognition................[4]')
disp('.........Delete Database.................[5]')
disp('.........ID Information..................[6]')
disp('.........Mean Face and EigenFaces........[7]')
disp('********************************************')
disp('Quit.....................................[Q]')
disp('Reset....................................[R]')
disp('                                 ')
y=input('Your Choice-->     ','s');



switch(y)
    case '1'
       [ans,pathname]=uigetfile( ...
{'*.jpg';'*.jpeg'...

   }, ...
   'Select an IMAGE');

        
if isequal(ans,0);
disp('ACTION CANCELLED');
h = waitbar(0,'PLEASE WAIT...');
for i=1:2450, 
waitbar(i/100)

end
close(h)
clear all
close all
bdrfacerec
return

end
 try
img=imread([pathname ans]);

if size(img,3)~1;
    img=rgb2gray(img);
img=imresize(img,[250 250]);      
figure,imshow(img)
bdrfacerec
return
end

if size(img,3)~0;
    disp(' PLEASE SELECT A COLOR IMAGE !!!')
    bdrfacerec
    return
end


catch
clc
disp('INCORRECT FILE FORMAT')
disp(' ')
disp('Press any key to continue...')
pause
bdrfacerec
 return
 end

        
   case '2'
        checkdata
        
    case'3'
        datainfo
    case'4'
        facerec
        
    case'5'
        deldata
    
    case'Q'
        clc
        clear all
        close all
        warndlg('THANKS FOR USING UFR v1.0',' ');
 case'q'
        clc
        clear all
        close all
        warndlg('THANKS FOR USING UFR v1.0',' ');
        
         
    case 'r'
        clc
        clear all
        close all
        bdrfacerec
        
        
       case 'R'
        clc
        clear all
        close all
        bdrfacerec 
    
    case '6'
        clc
        ginfo
        
    case '7'
        eigen
    
    
    otherwise
clc
        disp('Wrong SELECTION!!')
        disp(' ')
        disp('Press any key to continue...')
   pause     
        bdrfacerec
        return
end