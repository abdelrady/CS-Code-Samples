mem(E,[E|T]).
mem(E,[x|T]):-
   mem(E,T).