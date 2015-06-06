%FACE RECOGNITION SCRIPT
%First takes the last selected image
%Calls the images from database
%Applies PCA to images
%Compares the last selected image with database images and says if it is
%found at the database or not.


clc
close all



try    
img2=double(img(:));

if(exist('fdata.dat')==2)
        
        load('fdata.dat','-mat');
        mtr=zeros(size(data{1,1},1),fnumber);
        for ii=1:fnumber
            mtr(:,ii)=double(data{ii,1}); %Calling the images from database
            mtr2=double(mtr)/255;
            avr = mean(mtr2')';     %taking the average of the training set
            for i=1:fnumber 
            mtr2(:,i) = mtr2(:,i) - avr;  
            
            end
            
           
        end


Lmat = mtr2'*mtr2    ;                  %Obtaining the L matrix

[V,D] = eig(Lmat);                      %eigen values(D) and eigenvectors(V) of the L matrix 

  %obtaining eigenfaces 
V = mtr2*V*(abs(D))^-0.5 ;        %This line is taken from the software karhunenloeve.m
                                  %Available at
                                  %http://www.mathworks.com/matlabcentral/fileexchange/loadFile.do?objectId=6995&objectType=file
                                  %Author:Alex Chirokov

                                    
                                    

        
        f1=V'*(img2-avr) ;           % feature vector of the new image


        
         fdata=zeros(max_class,max_class); %empty matrice
         
      
         for ii=1:fnumber
             imdata=double(data{ii,1});
             classdata=data{ii,2};
             cor=V'*(imdata-avr); % weight vector of the stored faces
        
             fdata(:,classdata)=fdata(:,classdata)+cor;
           
         end
        
         dist=zeros(max_class,1);
         for ii=1:(max_class)
             dist(ii)=norm(f1-fdata(:,ii)); 
           
         end
         
         [minf,pminf]=min(dist);
         k=minf/1000;
     
         hll = waitbar(0,'CHECKING THE DATABASE...');
 for i=1:2450, 
 waitbar(i/100)
 
 end
 close(hll)
        
         if k<=6.1
             
             disp(strcat('The corresponding ID number of the face is --> ',num2str(pminf)));
              
             pause
           ldinfo
          
             return
         end
         if k>=6.1
             disp('The corresponding face does not exist at your database')
             disp('Note: Save more pictures to the group for the best recognition')
             disp(strcat('The similar of this face has an ID, number--> ',num2str(pminf)));
            
             pause
        ldinfo
           
            
            return
         end
        
else
                        clc
      disp('IMAGE PROCESSING IS NOT AVAILABLE')
      disp('*********************************')
      disp('Possible Reasons:                ')
      disp(' ')
      disp('1- Database is empty')
      disp('2- The size of the selected image is not suitable for processing')
      disp('3- The color or format is not matching with database')
      disp(' ')
      disp('Press any key to continue')
      pause
      clear all
      bdrfacerec
      end


    catch
    clc
    disp(' ')
    disp('NO FACE HAS BEEN SELECTED!!')
pause
clear all
bdrfacerec
end

    