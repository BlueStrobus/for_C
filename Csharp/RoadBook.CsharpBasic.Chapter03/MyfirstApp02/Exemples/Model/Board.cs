﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples.Model
{
    /// <summary>
    /// 게시판
    /// </summary>
    public class Board
    {
        /// <summary>
        /// 게시글 번호
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 게시글 제목
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 게시글 내용
        /// </summary>
        public string Contents { get; set; }
        /// <summary>
        /// 작성자
        /// </summary>
        public string Writer { get; set; }
        /// <summary>
        /// 작성일
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 수정일
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
