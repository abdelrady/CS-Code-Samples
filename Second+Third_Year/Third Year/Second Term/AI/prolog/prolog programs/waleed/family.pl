parent(ali,ahmed).
parent(ali,hassan).
parent(ali,hoda).
parent(hossam,hassan).
parent(hossam,yussra).
parent(hoda,heba).
parent(nagwa,ali).
parent(alia,hossam).
parent(hoda,mohamed).
     brother(X,Y):-            parent(Z,X),
                               parent(Z,Y),
                               male(X).
     son(X,Y):-                parent(Y,X).
     
            