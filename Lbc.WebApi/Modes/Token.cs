﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Lbc.WebApi.Modes {
    
    
    public class Token {

        [JsonProperty("access_token")]
        public string AccessToken {
            get;
            set;
        }

        [JsonProperty("token_type")]
        public string TokenType {
            get;
            set;
        }


        [JsonProperty("expires_in")]
        public int ExpressIn {
            get;
            set;
        }

        [JsonProperty("userId")]
        public int UserID {
            get;
            set;
        }

        [JsonProperty("userCode")]
        public string Account {
            get;
            set;
        }

        public bool IsLogined {
            get;
            set;
        }

        public DateTime? LoginedOn {
            get;
            set;
        }


        /// <summary>
        /// 是否登陆成功
        /// </summary>
        public bool IsLoginedSuccess {
            get {
                return
                    !string.IsNullOrWhiteSpace(this.AccessToken)
                    && this.UserID > 0
                    && !string.IsNullOrWhiteSpace(this.Account);
            }
        }

        /// <summary>
        /// 是否已经过期
        /// </summary>
        public bool IsExpressed {
            get {
                return
                    this.LoginedOn.HasValue
                    && this.LoginedOn.Value.AddSeconds(this.ExpressIn) <= DateTime.Now;
            }
        }
    }
}
