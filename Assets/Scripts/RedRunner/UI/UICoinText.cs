﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RedRunner.Collectables;
using System;

namespace RedRunner.UI
{
	public class UICoinText : UIText
	{
		[SerializeField]
		protected string m_CoinTextFormat = "x {0}";

		protected override void Awake ()
		{
			base.Awake ();
		}

        protected override void Start()
        {
	        try
	        {
		        UpdateCoinsText(GameManager.Singleton.m_Coin.Value);
	        }
	        catch (Exception)
	        {
		        // ignored
	        }
        }

        private void UpdateCoinsText(int newCoinValue)
        {
            GetComponent<Animator>().SetTrigger("Collect");
            text = string.Format(m_CoinTextFormat, newCoinValue);
        }
	}
}