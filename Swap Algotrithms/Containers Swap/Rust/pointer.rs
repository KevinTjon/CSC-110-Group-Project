
fn main(){
    let mut x =  5;
    let mut y =  42;

    std::mem::swap(&mut x, &mut y);
    
    println!("Numbers after swapping:");
    println!("\tx: {}",x);
    println!("\tt: {}",y);

}
