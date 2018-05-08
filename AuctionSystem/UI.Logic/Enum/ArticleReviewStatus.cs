using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Enum
{
	public enum ArticleReviewStatus
	{
		[Description("未审核")]
		WaitReview = 0,

		[Description("审核不通过")]
		ReviewFailure = 1,

		[Description("审核通过")]
		ReviewSuccess = 2
	}


}
