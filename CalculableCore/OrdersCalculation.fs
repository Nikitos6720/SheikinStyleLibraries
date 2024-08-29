namespace CalculableCore.OrdersCalculation

module OrderCalculation =
    
    ///<summary>
    /// Calculates summary cost of the order
    /// </summary>
    /// <param name="l">List of prices of some order lines</param>
    let Summary(l : int list) = 
        let mutable summary = 0
        
        for i in l do
            summary <- summary + i

        summary

    /// <summary>
    /// Calculates discount of the order by selected percentage
    /// </summary>
    /// <param name="basePrice">Basical cost of order</param>
    /// <param name="percentage">Selected percentage</param>
    let Discount(basePrice: double, percentage: int16):
        let discountRatio = percentage / 100
        let discount      = basePrice - (basePrice * discountRatio)=
        discount
    