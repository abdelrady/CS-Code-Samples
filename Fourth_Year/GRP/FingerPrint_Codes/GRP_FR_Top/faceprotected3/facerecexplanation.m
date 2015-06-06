%FACE RECOGNITION SYSTEM
%
% Face recognition system based on EigenFaces Method and Karhunen-Loeve algorithm
% The system functions by projecting face images onto a feature space
% that spans the significant variations among known face images. The
% significant features are known as "eigenfaces" because they are the
% eigenvectors (principal components) of the set of faces.
%
% Face images must be collected into sets: every set (called "class") should
% include a number of images for each person, with some variations in 
% expression and in the lighting. When a new input image is read and added
% to the training database, the number of class is required. Otherwise, a new 
% input image can be processed and confronted with all classes present in database.
% We choose a number of eigenvectors M' equal to the number of classes (see 
% algorithmic details in the cited references). Before start image
% processing first select input image. This image can be succesively added to
% database (training) or, if a database is already present, matched with
% known faces.
%
% Copy all files in Matlab current directory and type "facerec" on
% Matlab command window.
% 
% First, select an input image clicking on "Select image".
% Then you can
%   - add this image to database (click on "Add selected image to database"
%   - perform face recognition (click on "Face Recognition" button)
%     Note: If you want to perform face recognition database has to include 
%     at least one image.
%  If you choose to add image to database, a positive integer (face ID) is
%  required. This posivive integer is a progressive number which identifies
%  a person (each person corresponds to a class).
% For example:
%  - run the GUI (type "facerec" on Matlab command window)
%  - delete database (click on "Delete Database")
%  - add "mike1.jpg" to database ---> the ID has to be 1 since Mike is the first
%    person you are adding to database
%  - add "mike2.jpg" to database ---> the ID has to be 1 since you have already
%    added a Mike's image to database
%  - add "paul1.jpg" to database ---> the ID has to be 2 since Paul is the second person
%    you are adding to database
%  - add "cindy1.jpg" to database ---> the ID has to be 3 since Cindy is
%    the third person you are adding to database
%  - add "paul2.jpg" to database ---> the ID has to be 2 once again since
%    you have already added Paul to database
%   
% ... and so on! Very simple, isnt't? :)
% 
% The recognition gives as results the ID of nearest person present in
% database. For example if you select image "paul3.jpg" the ID given SHOULD
% be 2: "it should be" because errors are possible.
%
%
% The images included are taken from AT&T Laboratories Cambridge's
% Face DataBase. See the cited references for more informations.
% 
% 
% FUNCTIONS
%
% Select image:                                  read the input image
%
% Add selected image to database:                the input image is added to database and will be used for training
%
% Database Info:                                 show informations about the images present in database. Images must 
%                                                have the same size. If this is not true you have to resize them.
%
% Face Recognition:                              face matching. The selected input image is processed 
%
% Delete Database:                               remove database from the current directory
%
% Info:                                          show informations about this software
%
% Visualization tool:                            visualization utility
%
% Source code for Face Recognition System:       how to obtain the complete source code
%
% Exit:                                          quit program
%
%
%  References:
%  
%  AT&T Laboratories Cambridge. The ORL face database, Olivetti Research Laboratory available at
%  http://www.uk.research.att.com/pub/data/att_faces.zip
%  or http://www.uk.research.att.com/pub/data/att_faces.tar.Z
%
%
%
%
%
%*****************************************************************
% Luigi Rosa
% Via Centrale 35
% 67042 Civita di Bagno
% L'Aquila --- ITALY 
% email  luigi.rosa@tiscali.it
% mobile +39 3207214179
% website http://www.advancedsourcecode.com
%*****************************************************************
%
%