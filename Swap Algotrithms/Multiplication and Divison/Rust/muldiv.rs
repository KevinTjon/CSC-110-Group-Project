
fn main() {
    let mut num1:i32 = 6;
    let mut num2:i32 = 2;
    
    println!("Numbers before swapping:");
    println!("\tNum1: {}",num1);
    println!("\tNum2: {}",num2);

    num1 = num1*num2;
    num2 = num1/num2;
    num1 = num1/num2;

    println!("Numbers after swapping:");
    println!("\tNum1: {}",num1);
    println!("\tNum2: {}",num2);
}
