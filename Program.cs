using System;

namespace midterm_2{
          class Program{
                    static void Main(string[] args){
                              //initial variable
                              bool isweekend = false;
                              bool ismorning = false;
                              int breakfast = 5;
                              int weekend = 2;
                              int coffee = 3;
                              string order = "";
                              int massage;

                              //input variable
                              int day = int.Parse(Console.ReadLine());
                              int time = int.Parse(Console.ReadLine());

                              //checking date and time
                              if(day >= 6){
                                        isweekend = true;
                              }
                              if(time <= 11){
                                        ismorning = true;
                              }

                              //loop until "End"
                              while(order != "End"){
                                        //input
                                        order = Console.ReadLine();

                                        // checking and set massage accordingly
                                        // massage = 0 is end, set output as empty
                                        // massage = 1 is pass the condition, set output as empty
                                        // massage = 2 is "Please enter a valid menu"
                                        // massage = 3 is "Sorry your order is out of stock"
                                        // massage = 4 is "Sorry your order is not available"
                                        switch(order){
                                                  case"Breakfast Set":
                                                            if(breakfast > 0){
                                                                      if(ismorning){
                                                                                breakfast--;
                                                                                massage = 1;
                                                                      } else {
                                                                                massage = 4;
                                                                      }
                                                            } else {
                                                                      massage = 3;
                                                            }
                                                  break;
                                                  case"Weekend Set":
                                                            if(weekend > 0){
                                                                      if(isweekend){
                                                                                weekend--;
                                                                                massage = 1;
                                                                      } else {
                                                                                massage = 4;
                                                                      }
                                                            } else {
                                                                      massage = 3;
                                                            }
                                                  break;
                                                  case"Coffee":
                                                            if(coffee > 0){
                                                                                coffee--;
                                                                                massage = 1;
                                                            } else {
                                                                      massage = 3;
                                                            }
                                                  break;
                                                  case "End":
                                                            massage = 0;
                                                  break;
                                                  default:
                                                            massage = 2;
                                                  break;
                                        }

                                        //output
                                        switch(massage){
                                                  case 2:
                                                            Console.WriteLine("Please enter a valid menu");
                                                  break;
                                                  case 3:
                                                            Console.WriteLine("Sorry your order is out of stock");
                                                  break;
                                                  case 4:
                                                            Console.WriteLine("Sorry your order is not available");
                                                  break;
                                        }
                              }
                    }
          }
}