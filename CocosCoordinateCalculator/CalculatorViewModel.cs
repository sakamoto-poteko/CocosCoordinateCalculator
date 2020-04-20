using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace CocosCoordinateCalculator
{
    public class CalculatorViewModel : ViewModelBase
    {
        private double _canvasWidth;
        private double _canvasHeight;
        private double _objectWidth;
        private double _objectHeight;
        private double _objectX;
        private double _objectY;

        public double CanvasWidth
        {
            get => _canvasWidth;
            set
            {
                _canvasWidth = value;
                RaisePropertyChanged();
                RaiseCocosObjectCoordChangedX();
            }
        }

        public double CanvasHeight
        {
            get => _canvasHeight;
            set
            {
                _canvasHeight = value;
                RaisePropertyChanged();
                RaiseCocosObjectCoordChangedY();
            }
        }

        public double ObjectWidth
        {
            get => _objectWidth;
            set
            {
                _objectWidth = value;
                RaisePropertyChanged();
                RaiseCocosObjectCoordChangedX();
            }
        }

        public double ObjectHeight
        {
            get => _objectHeight;
            set
            {
                _objectHeight = value;
                RaisePropertyChanged();
                RaiseCocosObjectCoordChangedY();
            }
        }

        public double ObjectX
        {
            get => _objectX;
            set
            {
                _objectX = value;
                RaisePropertyChanged();
                RaiseCocosObjectCoordChangedX();
            }
        }

        public double ObjectY
        {
            get => _objectY;
            set
            {
                _objectY = value;
                RaisePropertyChanged();
                RaiseCocosObjectCoordChangedY();
            }
        }

        public double CocosObjectX
        {
            get
            {
                var originOffset = CanvasWidth / 2;
                var x = ObjectX + ObjectWidth / 2;
                x -= originOffset;
                return x;
            }
        }

        public double CocosObjectY
        {
            get
            {
                var originOffset = CanvasHeight / 2;
                var y = ObjectY + ObjectHeight / 2;
                y = originOffset - y;
                return y;
            }
        }

        private void RaiseCocosObjectCoordChangedX()
        {
            RaisePropertyChanged(nameof(CocosObjectX));
        }

        private void RaiseCocosObjectCoordChangedY()
        {
            RaisePropertyChanged(nameof(CocosObjectY));
        }
    }
}
