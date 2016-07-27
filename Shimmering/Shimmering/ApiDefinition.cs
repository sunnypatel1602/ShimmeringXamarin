using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreAnimation;

namespace Shimmering
{
	// @protocol FBShimmering <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FBShimmering
	{
		// @required @property (getter = isShimmering, assign, readwrite, nonatomic) BOOL shimmering;
		[Export ("shimmering")]
		bool Shimmering { [Bind ("isShimmering")] get; set; }

		// @required @property (assign, readwrite, nonatomic) CFTimeInterval shimmeringPauseDuration;
		[Export ("shimmeringPauseDuration")]
		double ShimmeringPauseDuration { get; set; }

		// @required @property (assign, readwrite, nonatomic) CGFloat shimmeringAnimationOpacity;
		[Export ("shimmeringAnimationOpacity")]
		nfloat ShimmeringAnimationOpacity { get; set; }

		// @required @property (assign, readwrite, nonatomic) CGFloat shimmeringOpacity;
		[Export ("shimmeringOpacity")]
		nfloat ShimmeringOpacity { get; set; }

		// @required @property (assign, readwrite, nonatomic) CGFloat shimmeringSpeed;
		[Export ("shimmeringSpeed")]
		nfloat ShimmeringSpeed { get; set; }

		// @required @property (assign, readwrite, nonatomic) CGFloat shimmeringHighlightLength;
		[Export ("shimmeringHighlightLength")]
		nfloat ShimmeringHighlightLength { get; set; }

		// @required @property (getter = shimmeringHighlightLength, assign, readwrite, nonatomic, setter = setShimmeringHighlightLength:) CGFloat shimmeringHighlightWidth __attribute__((deprecated("Use shimmeringHighlightLength")));
//		[Export ("shimmeringHighlightWidth")]
//		nfloat ShimmeringHighlightWidth { [Bind ("shimmeringHighlightLength")] get; [Bind ("setShimmeringHighlightLength:")] set; }

		// @required @property (assign, readwrite, nonatomic) FBShimmerDirection shimmeringDirection;
		[Export ("shimmeringDirection", ArgumentSemantic.Assign)]
		FBShimmerDirection ShimmeringDirection { get; set; }

		// @required @property (assign, readwrite, nonatomic) CFTimeInterval shimmeringBeginFadeDuration;
		[Export ("shimmeringBeginFadeDuration")]
		double ShimmeringBeginFadeDuration { get; set; }

		// @required @property (assign, readwrite, nonatomic) CFTimeInterval shimmeringEndFadeDuration;
		[Export ("shimmeringEndFadeDuration")]
		double ShimmeringEndFadeDuration { get; set; }

		// @required @property (readonly, assign, nonatomic) CFTimeInterval shimmeringFadeTime;
		[Export ("shimmeringFadeTime")]
		double ShimmeringFadeTime { get; }

		// @required @property (assign, nonatomic) CFTimeInterval shimmeringBeginTime;
		[Export ("shimmeringBeginTime")]
		double ShimmeringBeginTime { get; set; }
	}

	// @interface FBShimmeringLayer : CALayer <FBShimmering>
	[BaseType (typeof(CALayer))]
	interface FBShimmeringLayer : FBShimmering
	{
		// @property (nonatomic, strong) CALayer * contentLayer;
		[Export ("contentLayer", ArgumentSemantic.Strong)]
		CALayer ContentLayer { get; set; }
	}

	// @interface FBShimmeringView : UIView <FBShimmering>
	[BaseType (typeof(UIView))]
	interface FBShimmeringView : FBShimmering
	{
		// @property (nonatomic, strong) UIView * contentView;
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }
	}

}

