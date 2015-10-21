/**
 * Created by lucky on 10/21/2015.
 */
public enum AgeRestriction {
    NONE(0),
    TEENAGER(13),
    ADULT(18);

    private int value;

    AgeRestriction(int value) {
        this.value = value;
    }

    public int getValue() {
        return value;
    }
}
