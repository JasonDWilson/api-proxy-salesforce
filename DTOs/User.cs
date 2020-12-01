﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwpro.Api.Proxy.DTOs
{
    public class User
    {
        public Attributes attributes { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public object Division { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public object GeocodeAccuracy { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public bool EmailPreferencesAutoBcc { get; set; }
        public bool EmailPreferencesAutoBccStayInTouch { get; set; }
        public bool EmailPreferencesStayInTouchReminder { get; set; }
        public object SenderEmail { get; set; }
        public object SenderName { get; set; }
        public string Signature { get; set; }
        public object StayInTouchSubject { get; set; }
        public object StayInTouchSignature { get; set; }
        public object StayInTouchNote { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string MobilePhone { get; set; }
        public string Alias { get; set; }
        public string CommunityNickname { get; set; }
        public string BadgeText { get; set; }
        public bool IsActive { get; set; }
        public string TimeZoneSidKey { get; set; }
        public string UserRoleId { get; set; }
        public string LocaleSidKey { get; set; }
        public bool ReceivesInfoEmails { get; set; }
        public bool ReceivesAdminInfoEmails { get; set; }
        public string EmailEncodingKey { get; set; }
        public string ProfileId { get; set; }
        public string UserType { get; set; }
        public string LanguageLocaleKey { get; set; }
        public object EmployeeNumber { get; set; }
        public object DelegatedApproverId { get; set; }
        public string ManagerId { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedById { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime SystemModstamp { get; set; }
        public object OfflineTrialExpirationDate { get; set; }
        public object OfflinePdaTrialExpirationDate { get; set; }
        public bool UserPermissionsMarketingUser { get; set; }
        public bool UserPermissionsOfflineUser { get; set; }
        public bool UserPermissionsAvantgoUser { get; set; }
        public bool UserPermissionsCallCenterAutoLogin { get; set; }
        public bool UserPermissionsMobileUser { get; set; }
        public bool UserPermissionsSFContentUser { get; set; }
        public bool UserPermissionsInteractionUser { get; set; }
        public bool UserPermissionsSupportUser { get; set; }
        public bool UserPermissionsChatterAnswersUser { get; set; }
        public bool ForecastEnabled { get; set; }
        public bool UserPreferencesActivityRemindersPopup { get; set; }
        public bool UserPreferencesEventRemindersCheckboxDefault { get; set; }
        public bool UserPreferencesTaskRemindersCheckboxDefault { get; set; }
        public bool UserPreferencesReminderSoundOff { get; set; }
        public bool UserPreferencesDisableAllFeedsEmail { get; set; }
        public bool UserPreferencesDisableFollowersEmail { get; set; }
        public bool UserPreferencesDisableProfilePostEmail { get; set; }
        public bool UserPreferencesDisableChangeCommentEmail { get; set; }
        public bool UserPreferencesDisableLaterCommentEmail { get; set; }
        public bool UserPreferencesDisProfPostCommentEmail { get; set; }
        public bool UserPreferencesContentNoEmail { get; set; }
        public bool UserPreferencesContentEmailAsAndWhen { get; set; }
        public bool UserPreferencesApexPagesDeveloperMode { get; set; }
        public bool UserPreferencesHideCSNGetChatterMobileTask { get; set; }
        public bool UserPreferencesDisableMentionsPostEmail { get; set; }
        public bool UserPreferencesDisMentionsCommentEmail { get; set; }
        public bool UserPreferencesHideCSNDesktopTask { get; set; }
        public bool UserPreferencesHideChatterOnboardingSplash { get; set; }
        public bool UserPreferencesHideSecondChatterOnboardingSplash { get; set; }
        public bool UserPreferencesDisCommentAfterLikeEmail { get; set; }
        public bool UserPreferencesDisableLikeEmail { get; set; }
        public bool UserPreferencesSortFeedByComment { get; set; }
        public bool UserPreferencesDisableMessageEmail { get; set; }
        public bool UserPreferencesDisableBookmarkEmail { get; set; }
        public bool UserPreferencesDisableSharePostEmail { get; set; }
        public bool UserPreferencesEnableAutoSubForFeeds { get; set; }
        public bool UserPreferencesDisableFileShareNotificationsForApi { get; set; }
        public bool UserPreferencesShowTitleToExternalUsers { get; set; }
        public bool UserPreferencesShowManagerToExternalUsers { get; set; }
        public bool UserPreferencesShowEmailToExternalUsers { get; set; }
        public bool UserPreferencesShowWorkPhoneToExternalUsers { get; set; }
        public bool UserPreferencesShowMobilePhoneToExternalUsers { get; set; }
        public bool UserPreferencesShowFaxToExternalUsers { get; set; }
        public bool UserPreferencesShowStreetAddressToExternalUsers { get; set; }
        public bool UserPreferencesShowCityToExternalUsers { get; set; }
        public bool UserPreferencesShowStateToExternalUsers { get; set; }
        public bool UserPreferencesShowPostalCodeToExternalUsers { get; set; }
        public bool UserPreferencesShowCountryToExternalUsers { get; set; }
        public bool UserPreferencesShowProfilePicToGuestUsers { get; set; }
        public bool UserPreferencesShowTitleToGuestUsers { get; set; }
        public bool UserPreferencesShowCityToGuestUsers { get; set; }
        public bool UserPreferencesShowStateToGuestUsers { get; set; }
        public bool UserPreferencesShowPostalCodeToGuestUsers { get; set; }
        public bool UserPreferencesShowCountryToGuestUsers { get; set; }
        public bool UserPreferencesPipelineViewHideHelpPopover { get; set; }
        public bool UserPreferencesHideS1BrowserUI { get; set; }
        public bool UserPreferencesDisableEndorsementEmail { get; set; }
        public bool UserPreferencesPathAssistantCollapsed { get; set; }
        public bool UserPreferencesCacheDiagnostics { get; set; }
        public bool UserPreferencesShowEmailToGuestUsers { get; set; }
        public bool UserPreferencesShowManagerToGuestUsers { get; set; }
        public bool UserPreferencesShowWorkPhoneToGuestUsers { get; set; }
        public bool UserPreferencesShowMobilePhoneToGuestUsers { get; set; }
        public bool UserPreferencesShowFaxToGuestUsers { get; set; }
        public bool UserPreferencesShowStreetAddressToGuestUsers { get; set; }
        public bool UserPreferencesLightningExperiencePreferred { get; set; }
        public bool UserPreferencesPreviewLightning { get; set; }
        public bool UserPreferencesHideEndUserOnboardingAssistantModal { get; set; }
        public bool UserPreferencesHideLightningMigrationModal { get; set; }
        public bool UserPreferencesHideSfxWelcomeMat { get; set; }
        public bool UserPreferencesHideBiggerPhotoCallout { get; set; }
        public bool UserPreferencesGlobalNavBarWTShown { get; set; }
        public bool UserPreferencesGlobalNavGridMenuWTShown { get; set; }
        public bool UserPreferencesCreateLEXAppsWTShown { get; set; }
        public bool UserPreferencesFavoritesWTShown { get; set; }
        public bool UserPreferencesRecordHomeSectionCollapseWTShown { get; set; }
        public bool UserPreferencesRecordHomeReservedWTShown { get; set; }
        public bool UserPreferencesFavoritesShowTopFavorites { get; set; }
        public bool UserPreferencesExcludeMailAppAttachments { get; set; }
        public bool UserPreferencesSuppressTaskSFXReminders { get; set; }
        public bool UserPreferencesSuppressEventSFXReminders { get; set; }
        public bool UserPreferencesPreviewCustomTheme { get; set; }
        public bool UserPreferencesHasCelebrationBadge { get; set; }
        public bool UserPreferencesUserDebugModePref { get; set; }
        public bool UserPreferencesNewLightningReportRunPageEnabled { get; set; }
        public object ContactId { get; set; }
        public object AccountId { get; set; }
        public object CallCenterId { get; set; }
        public object Extension { get; set; }
        public object FederationIdentifier { get; set; }
        public string AboutMe { get; set; }
        public string FullPhotoUrl { get; set; }
        public string SmallPhotoUrl { get; set; }
        public bool IsExtIndicatorVisible { get; set; }
        public string OutOfOfficeMessage { get; set; }
        public string MediumPhotoUrl { get; set; }
        public string DigestFrequency { get; set; }
        public string DefaultGroupNotificationFrequency { get; set; }
        public DateTime LastViewedDate { get; set; }
        public DateTime LastReferencedDate { get; set; }
        public string BannerPhotoUrl { get; set; }
        public string SmallBannerPhotoUrl { get; set; }
        public string MediumBannerPhotoUrl { get; set; }
        public bool IsProfilePhotoActive { get; set; }
    }
}
