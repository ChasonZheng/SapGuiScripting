using System;

namespace SapGuiScripting.session {
    internal class NoSapGuiFoundException : Exception {
        public NoSapGuiFoundException() {
        }

        public NoSapGuiFoundException(string message) : base(message) {
        }

        public NoSapGuiFoundException(string message, Exception inner) : base(message, inner) {
        }
    }
}