﻿using NServiceBus.Extensibility;
using NServiceBus.Routing;
using NServiceBus.Transport;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NServiceBus.Transport.Kafka.Tests
{
    [TestFixture]
    class When_consuming_messages:KafkaContext
    {
        int TIMEOUT = 20;
        int MAXMESSAGES = 10;

  /*      [Test]
        public async Task Should_block_until_a_message_is_available()
        {
            base.SetUp();
                       
            var message = new OutgoingMessage("fixed token", new Dictionary<string, string>(), new byte[0]);
            var transportOperations = new TransportOperations(new TransportOperation(message, new UnicastAddressTag(endpointName)));

            await messageDispatcher.Dispatch(transportOperations, new TransportTransaction(), new ContextBag());

            var receivedMessages = ReceiveMessages(TIMEOUT, MAXMESSAGES);

            Assert.AreEqual(message.MessageId, receivedMessages.ToList()[0].MessageId);


        }*/

      
    }
}
