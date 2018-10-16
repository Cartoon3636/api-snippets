<?php
require_once 'vendor/autoload.php';
use Twilio\TwiML\VoiceResponse;

$response = new VoiceResponse();
$response->say('Calling Twilio Pay');
$response->pay(['chargeAmount' => '20.45', 'action' => 'https://enter-your-callback-function-url.twil.io/pay']);

echo $response;