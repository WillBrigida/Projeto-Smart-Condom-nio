using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace CondominioSmart.ViewModels
{
    public class ScannerViewModel : BaseViewModel
    {
        #region Propriedades
        MenuViewModel menu;

        private bool _IsVisible = false;

        public bool IsVisible
        {
            get { return this._IsVisible; }
            set { this.SetProperty(ref this._IsVisible, value); }
        }


        private bool _IsScanning = false;

        public bool IsScanning
        {
            get { return this._IsScanning; }
            set { this.SetProperty(ref this._IsScanning, value); }
        }

        private bool _IsAnalyzing = false;

        public bool IsAnalyzing
        {
            get { return this._IsAnalyzing; }
            set { this.SetProperty(ref this._IsAnalyzing, value); }
        }


        private Result _Result;

        public Result Result
        {
            get { return this._Result; }
            set { this.SetProperty(ref this._Result, value); }
        }



        private string _campo;
        public string Campo
        {
            get { return this._campo; }
            set { this.SetProperty(ref this._campo, value); }
        }

        ZXingScannerView zxing;
        ZXingDefaultOverlay overlay;
        #endregion

        #region Command
        public ICommand BarCodeScannerCommand { get { return new Command(BarCodeScanner); } }
        public ICommand ScanResultCommand { get { return new Command(ScanResult); } }
        public ICommand QRCodeScannerCommand { get { return new Command(QRCodeScanner); } }
        #endregion

        #region Construtor
        public ScannerViewModel()
        {
            var fooMobileBarcodeScanningOptions = new MobileBarcodeScanningOptions();
            fooMobileBarcodeScanningOptions.PossibleFormats = new List<ZXing.BarcodeFormat>() {
                BarcodeFormat.QR_CODE,
                BarcodeFormat.CODE_128,
                BarcodeFormat.CODE_39,
                BarcodeFormat.CODABAR
            };
            BarCodeScanner();
        }
        #endregion

        #region Métodos
        private async void ScanResult()
        {
            menu = new MenuViewModel();
            //throw new NotImplementedException();
            this.IsVisible = false;
            //this.IsScanning = false;
            this.IsAnalyzing = false;
            this.Campo = Result.Text;
            menu.Entry = Campo;
            await App.Current.MainPage.Navigation.PopModalAsync();
            
        }

        private void BarCodeScanner()
        {
            //throw new NotImplementedException();
            this.IsVisible = true;
            this.IsScanning = true;
            this.IsAnalyzing = true;
        }


        private void QRCodeScanner()
        {
            this.IsVisible = true;
            this.IsScanning = true;
            this.IsAnalyzing = true;
        }
        #endregion

    }
}



