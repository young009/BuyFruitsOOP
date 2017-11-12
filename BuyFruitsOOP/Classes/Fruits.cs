using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyFruitsOOP.Classes;

namespace BuyFruitsOOP.Classes {
    public class Fruits {
        //Default concstructor
        public Fruits() {

        }

        public fruitName fruitname { get; set; }
        public fruitPrice fruitPrice { get; set; }
        public promotion promotion { get; set; }
        public double subtotal { get; set; }

        /// <summary>
        /// Validate input quantity >0
        /// </summary>
        /// <param name="qty"></param>
        /// <returns></returns>
        public static bool validateQty(int qty) {
            if (qty <= 0) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validate input order in range
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool validateOrder(int order) {
            if (order < 1 && order > 3)
                return true;
            return false;
        }

        /// <summary>
        /// Validate customer buying quantity and give discount respectively.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public double checkPromotion(int quantity) {
            try {
                if (quantity >= (double)purchaseQuantity.qty20) {
                    promotion = promotion.discount30;
                }
                else if (quantity >= (double)purchaseQuantity.qty10) {
                    promotion = promotion.discount10;
                }
                else {
                    promotion = promotion.discount0;
                }
                return subtotal = subtotal * (double)promotion / 100;
            }
            catch (DivideByZeroException e) {
                throw new InvalidOperationException("Could not complete operation", e);
            }
        }

        /// <summary>
        /// Identify product order and 
        /// </summary>
        /// <param name="fruit"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public double getSubTotal(fruitName fruit, int quantity) {
            try {
                switch (fruit) {
                    case fruitName.apple: {
                            fruitPrice = fruitPrice.applePrice;
                            break;
                        }
                    case fruitName.banana: {
                            fruitPrice = fruitPrice.bananaPrice;
                            break;
                        }
                    case fruitName.grape: {
                            fruitPrice = fruitPrice.grapePrice;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid Selection. Enter number to select.");
                        break;
                }

                subtotal = quantity * (double)fruitPrice;
                checkPromotion(quantity);
                return subtotal;
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
