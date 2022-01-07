﻿using System.Collections.Generic;
using Amazon.Pay.API.DeliveryTracker;
using Amazon.Pay.API.InStore.Charge;
using Amazon.Pay.API.InStore.MerchantScan;
using Amazon.Pay.API.InStore.Refund;

namespace Amazon.Pay.API.InStore.Interfaces
{
    public interface IInStoreClient : IClient
    {
        /// <summary>
        /// Informs Amazon Pay that a buyer wants to initiate a purchase with a merchant.
        /// </summary>
        /// <param name="scanRequest"></param>
        /// <param name="headers"></param>
        /// <returns>AmazonPayResponse response</returns>
        MerchantScanResponse MerchantScan(MerchantScanRequest scanRequest, Dictionary<string, string> headers = null);

        /// <summary>
        /// Charges the buyer using the ChargePermission generated by the MerchantScan call.
        /// </summary>
        /// <param name="chargeRequest"></param>
        /// <param name="headers"></param>
        /// <returns>AmazonPayResponse response</returns>
        ChargeResponse Charge(CreateChargeRequest chargeRequest, Dictionary<string, string> headers = null);

        /// <summary>
        /// Refunds the given amount for the given charge.
        /// </summary>
        /// <param name="refundRequest"></param>
        /// <param name="headers"></param>
        /// <returns>AmazonPayResponse response</returns>
        RefundResponse Refund(CreateRefundRequest refundRequest, Dictionary<string, string> headers = null);
   }
}