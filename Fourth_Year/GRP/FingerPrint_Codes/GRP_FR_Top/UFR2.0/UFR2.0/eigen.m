%displays eigenfaces and the mean face if the database is not EMPTY
%partially taken from the software karhunenloeve.m
%Author:Alex Chirokov
%Available at
%http://www.mathworks.com/matlabcentral/fileexchange/loadFile.do?objectId=6995&objectType=file

close all
if(exist('fdata.dat')==2)
        try
        load('fdata.dat','-mat');
       matrice=zeros(size(data{1,1},1),fnumber);
        for ii=1:fnumber
            matrice(:,ii)=double(data{ii,1});
            imsize=[250 250];
            nPixels = imsize(1)*imsize(2);
            matrice2=double(matrice)/255;
            avrgx = mean(matrice2')';
           for i=1:fnumber 
            matrice2(:,i) = matrice2(:,i) - avrgx;
           end
            
            imshow(reshape(avrgx, imsize)); title('mean face')
        end


cov_mat = matrice2'*matrice2;

[V,D] = eig(cov_mat); 

V = matrice2*V*(abs(D))^-0.5;


for ii=1:fnumber
figure,imshow(ScaleImage(reshape(V(:,ii),imsize))); 
end
bdrfacerec

        catch
disp('Mean face and eigenfaces cannot be shown!!!')
disp('Possible Reasons:')
disp(' ')
disp('1--> Check the size of the new image and stored image(s) if you change the imresize line at bdrfacerec.m')
disp('2--> Database is empty')
disp('3--> There is only one person in your database. Please add atleast one person more to see the average of faces')
       pause
       
        bdrfacerec
 end
else
    clc
    disp(' CORRESPONDING FACE DATABASE NOT FOUND !!!')
    disp(' ')
    disp(' Press any key to continue ')
        pause
bdrfacerec
end
    
