var nam = 0
for( ; nam<=100; nam++) {
   if(nam == 0) {
      console.log(`undefined`);
   } else if(nam % 15 === 0){
      console.log(`${nam} =FizzBazz`);
   }else if(nam % 3 === 0) {
      console.log(`${nam} =Fizz`);
   }else if(nam % 5===0) {
      console.log(`${nam} =Bazz`);
   }else {
      console.log(`${nam}`);
   }
}