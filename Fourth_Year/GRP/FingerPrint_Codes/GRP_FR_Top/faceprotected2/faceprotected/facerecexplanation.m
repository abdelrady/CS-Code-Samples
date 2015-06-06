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
% mobile +39 320 7214179
% http://utenti.lycos.it/matlab
%*****************************************************************
%
%