import java.math.BigDecimal;

/**
 * Created by lucky on 10/21/2015.
 */
public class Appliance extends ElectronicsProduct {
    private final int totalQuantityForIncreasedPrice = 50;
    private final BigDecimal extraPercentage = new BigDecimal(5);

    public Appliance(String name, BigDecimal price, double quantity){
        super(name,price,quantity, AgeRestriction.NONE, GuaranteePeriod.APPLIANCE);
        this.setPrice(price);
    }

    @Override
    public void setPrice(BigDecimal price){
        if (this.getQuantity() <= totalQuantityForIncreasedPrice) {
            super.setPrice(price.add(percentage(price, extraPercentage)));
        }
    }
}
