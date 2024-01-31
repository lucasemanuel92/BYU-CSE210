using System;

class Word {
        private string _saying;
        private bool _isHidden;

        public Word(string saying)
        {
            this._saying = saying;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public string GetText()
        {
            return _saying;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }
}
