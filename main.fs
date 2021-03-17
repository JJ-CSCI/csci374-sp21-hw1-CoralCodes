module Assignment

// Can't use library functions just head tail and isempty
//No indexes

// Problem 1
let rec tribn n =
    // write your code here
    if n <= 0 then 0 
    elif n = 1  then 1
    elif n = 2  then 1
    else tribn(n - 1) + tribn(n - 2) + tribn(n - 3)

// Problem 2
let tribn2 n =
  let rec sum3 cnt lst =
    if cnt = 0 then 0
    else
      (List.head lst) +(sum3(cnt-1)(List.tail lst))
  
  let rec loop n lst = 
    let next = sum3 3 lst
    if n = 0 then next
    else loop (n-1) (nex::lst)

  if n <= 0 then 0
  elif n = 1 then 1
  elif n = 2 then 1
  else loop (n-3) [1;1;0]



    // write your code here
    //let list = []
   // let sum = List.head lst + (List.head+1 lst) + (List.head +2 lst) +(List.head +3 lst)
   // List.head lst = sum

// Problem 3
let rec last (lst:int list) = 
    // write your code here
    let h =List.head lst
    let t = List.tail lst
    if List.isEmpty t then h
    else last t
    
    //if lst.Tail.IsEmpty then List.head lst
    //else last (List.tail lst)
    
// Problem 4
let fourth (lst:int list) =
    // write your code here
    let rec loop cnt lst =
      if List.isEmpty lst then 0
      else
        if cnt = 1 then 
          List.head lst 
        else 
          loop (cnt-1) (List.tail lst)
    
    loop 4 lst

// Problem 5
let everyfourth (lst:int list) =[]
    // write your code here
  // let rec loop cnt lst = 
    //  if List.isEmpty lst then []
      //else 
        //let h = List.head lst 
        //let t = List.tail lst
        //if cnt = 1 then h :: loop 4 t
        //else loop (cnt-1) t 
    //loop 4 lst 

// Problem 6
let rec take n (lst:int list) =
    // write your code here
    if (List.isEmpty lst) || n = 0 then []
    else
      (List.head lst) :: take (n-1)(List.tail lst)

// Problem 7
let rec drop n (lst:int list) =
    // write your code here
  if List.isEmpty lst then []
  elif n = 0 then lst 
  else drop (n-1) (List.tail lst)
