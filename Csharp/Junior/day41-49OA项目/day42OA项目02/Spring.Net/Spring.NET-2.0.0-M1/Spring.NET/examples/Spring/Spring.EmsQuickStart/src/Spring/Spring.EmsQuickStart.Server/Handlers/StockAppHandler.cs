

using System.Collections;
using Spring.EmsQuickStart.Common.Data;
using Spring.EmsQuickStart.Server.Services;
using Spring.Util;

namespace Spring.EmsQuickStart.Server.Handlers
{
    public class StockAppHandler
    {
        private IExecutionVenueService executionVenueService;

        private ICreditCheckService creditCheckService;

        private ITradingService tradingService;

        public StockAppHandler(IExecutionVenueService executionVenueService, ICreditCheckService creditCheckService, ITradingService tradingService)
        {
            this.executionVenueService = executionVenueService;
            this.creditCheckService = creditCheckService;
            this.tradingService = tradingService;
        }

        public TradeResponse Handle(TradeRequest tradeRequest)
        {
            TradeResponse tradeResponse;
            ArrayList errors = new ArrayList();
            if (creditCheckService.CanExecute(tradeRequest, errors))
            {
                tradeResponse = executionVenueService.ExecuteTradeRequest(tradeRequest);
            }
            else
            {
                tradeResponse = new TradeResponse();
                tradeResponse.Error = true;
                tradeResponse.ErrorMessage = StringUtils.ArrayToCommaDelimitedString(errors.ToArray());
                
            }
            tradingService.ProcessTrade(tradeRequest, tradeResponse);
            return tradeResponse;
        }
    }
}