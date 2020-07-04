using UnityEngine;
using System.Collections;
using Soomla.Store;
using System.Collections.Generic;

public class SoomlaIntegration : IStoreAssets
{

    public int GetVersion()
    {
        return 0;
    }

    /// <summary>
    /// see parent.
    /// </summary>
    public VirtualCurrency[] GetCurrencies()
    {
        return new VirtualCurrency[] { COINS_CURRENCY };
    }
    
    public VirtualCurrencyPack[] GetCurrencyPacks()
    {
        return new VirtualCurrencyPack[] { PACK1, PACK2, PACK3, PACK4 };
    }

    public const string COINS_CURRENCY_ITEM_ID = "coins";

    public const string PACK1_PRODUCT_ID = "pack1";

    public const string PACK2_PRODUCT_ID = "pack2";

    public const string PACK3_PRODUCT_ID = "pack3";

    public const string PACK4_PRODUCT_ID = "pack4";



    /** Virtual Currency Packs **/

    public static VirtualCurrency COINS_CURRENCY = new VirtualCurrency(
               "Coins",										// name
               "",												// description
               COINS_CURRENCY_ITEM_ID							// item id
       );


    public static VirtualCurrencyPack PACK1 = new VirtualCurrencyPack(
            "10 coins",                                   // name
            "10 coins",                       // description
            "pack1",                                   // item id
            10,												// number of currencies in the pack
            COINS_CURRENCY_ITEM_ID,                        // the currency associated with this pack
            new PurchaseWithMarket( PACK1_PRODUCT_ID, 0.99 )
    );

    public static VirtualCurrencyPack PACK2 = new VirtualCurrencyPack(
            "50 coins",                                   // name
            "50 coins",                 // description
            "pack2",                                   // item id
            50,                                             // number of currencies in the pack
            COINS_CURRENCY_ITEM_ID,                        // the currency associated with this pack
            new PurchaseWithMarket( PACK2_PRODUCT_ID, 4.99 )
    );

    public static VirtualCurrencyPack PACK3 = new VirtualCurrencyPack(
            "100 coins",                                  // name
            "100 coins",                 	// description
            "pack3",                                  // item id
            100,                                            // number of currencies in the pack
            COINS_CURRENCY_ITEM_ID,                        // the currency associated with this pack
            new PurchaseWithMarket( PACK3_PRODUCT_ID, 9.99 )
    );

    public static VirtualCurrencyPack PACK4 = new VirtualCurrencyPack(
            "150 coins",                                 // name
            "150 coins",                 		// description
            "pack4",                                 // item id
            150,                                           // number of currencies in the pack
            COINS_CURRENCY_ITEM_ID,                        // the currency associated with this pack
            new PurchaseWithMarket( PACK4_PRODUCT_ID, 14.99 )
    );



    public VirtualGood[] GetGoods()
    {
       return new VirtualGood[]{} ;
    }

    public static VirtualCategory GENERAL_CATEGORY = new VirtualCategory(
                   "General", new List<string>( new string[] { PACK1_PRODUCT_ID, PACK2_PRODUCT_ID, PACK3_PRODUCT_ID, PACK4_PRODUCT_ID } )
           );


    public VirtualCategory[] GetCategories()
    {
        return new VirtualCategory[] { };
    }
}