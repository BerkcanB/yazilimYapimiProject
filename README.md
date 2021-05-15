# yazilimYapimiProject

Software Engineer class project

version:1.0
It is a simple sales and inventory automation where you can add or remove products, sell the products you add, buy with quantity.

-You need use a sql database(if you wanna it i can send to you my database)


Story1(User user)
{
  1. First of all, you open an account.
  
  2. On the login screen if you enter your informations correctly, the user screen opens.
  
    A. When MyPresence button clicked;
      a. You can see your products,
      b. You can sell your products,
      c. You can add money (with admin approval, sending some kind of request),
      d. You can add products (with admin approval, sending some kind of request).
    
    B. When Market button clicked;
      a. You can see products in market,
      b. You can buy a product of your choice in quantity. Example;
         -You want to buy 100 kg wheat. Jhon sells 50 kg of wheat for $ 1 and Emma sells 50 kg of wheat for $ 2.
         Algorithm firstly buys 50 kg of wheat from 1 $ from Jhon. You spent $ 50.
         Algorithm secondly buys 50 kg of wheat from 2 $ from Emma. You spent $ 100.
         You spent exactly $ 150.
}

Story2(Admin admin)
{
  1. On the login screen if you enter your informations correctly, the admin screen opens.
  
  2. You can choose which requests you want to see from combo box.
    -Add money requests
    -add product requests
   
  3. You can accept or refuse the request of your choice.
}
