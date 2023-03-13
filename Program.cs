using System;

namespace midterm_2{
          class Program{
                    static void Main(string[] args){
                              bool isweekend = false;
                              bool ismorning = false;
                              int breakfast = 5;
                              int weekend = 2;
                              int coffee = 3;

                              int day = int.Parse(Console.ReadLine());
                              int time = int.Parse(Console.ReadLine());
                              string order = "";
                              int massage;
                              if(day >= 6){
                                        isweekend = true;
                              }
                              if(time <= 11){
                                        ismorning = true;
                              }

                              while(order != "End"){
                                        order = Console.ReadLine();
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