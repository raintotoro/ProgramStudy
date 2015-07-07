
 object FizzBuzz extends App{

   fizzbuzz(100)

     def fizzBuzz(a:Int)={
         for(i <- 1 to a){
            if(i % 3 == 0 && i % 5 == 0){
              println("FizzBuzz")
            }
            else if(i % 3 == 0) {
              println("Fizz")
            }
            else if(i % 5 == 0) {
              println("Buzz")
            }
            else {
              println(i)
            }
         }
     }

}

