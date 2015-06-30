object Fibonucci extends App{
  lazy val fib: Stream[Int] = Stream.cons(0,Stream.cons(1,
    fib.zip(fib.tail).map(p => p._1 + p._2)))
  fib.take(47).foreach(println)
}