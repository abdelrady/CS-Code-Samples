% Displays how many faces stored in the facedatabase
clc
close all
clear('img');
if(exist('fdata.dat')==2)
    load('fdata.dat','-mat');
    
    disp(strcat('There are -->'   ,num2str(fnumber),' ID(s) at the database.'));
    
disp('press any key to continue')
pause
bdrfacerec
else
    disp('Database is empty');
    disp('press any key to continue')
    pause
    bdrfacerec

end

