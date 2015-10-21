/**
 * Created by lucky on 10/21/2015.
 */
public enum GuaranteePeriod {
    COMPUTER(24),
    APPLIANCE(6);

    private int value;

    GuaranteePeriod(int value) {
        this.value = value;
    }

    public int getValue() {
        return value;
    }
}