// Install the Java helper library from twilio.com/docs/java/install
import com.twilio.Twilio;
import com.twilio.rest.api.v2010.account.Message;
import com.twilio.type.PhoneNumber;

public class Example {
  // Find your Account Sid and Token at twilio.com/user/account
  public static final String ACCOUNT_SID = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
  public static final String AUTH_TOKEN = "your_auth_token";

  public static void main(String[] args) {
    Twilio.init(ACCOUNT_SID, AUTH_TOKEN);

    // TODO: Confirm calling setProvideFeedback works
    Message message = Message.create(new PhoneNumber("+15558675309"),
        new PhoneNumber("+15017250604"), "Open to confirm: http://yourserver.com/confirm?id=1234567890")
        setProvideFeedback(true)
        .execute();

    System.out.println(message.getSid());
  }
}
