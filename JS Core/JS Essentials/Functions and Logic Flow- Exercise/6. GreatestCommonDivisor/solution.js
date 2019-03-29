function greatestCD() {
   let a = document.getElementById("num1").value;
   let b = document.getElementById("num2").value;

   let gcd = function (a, b) {
      a = parseInt(a);
      b = parseInt(b);
      if (!b) {
         return a;
      }

      return gcd(b, a % b);
   };
   let result = gcd(a, b);
   document.getElementById("result").innerHTML = result;
}