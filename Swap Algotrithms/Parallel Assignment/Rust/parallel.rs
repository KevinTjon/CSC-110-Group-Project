
fn main(){
    let x =  5;
    let y =  42;

    let (x, y) = (y, x);
    
    println!("Numbers after swapping:");
    println!("\tx: {}",x);
    println!("\ty: {}",y);

}
