// Download the Node helper library from twilio.com/docs/node/install
// These are your accountSid and authToken from https://www.twilio.com/console
// To set up environmental variables, see http://twil.io/secure
const accountSid = process.env.TWILIO_ACCOUNT_SID;
const authToken = process.env.TWILIO_AUTH_TOKEN;

const client = require('twilio')(accountSid, authToken);

client.monitor.v1
  .alerts('NO5a7a84730f529f0a76b3e30c01315d1a')
  .fetch()
  .then(data => console.log(data.alertText));
